using Microsoft.AspNetCore.Mvc;
using PharmacyApi.Models.DTOs.MedicineDTOs;
using PharmacyApi.Services.Interfaces;
using SQLitePCL;

namespace PharmacyApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MedicinesController : ControllerBase
    {
        private readonly IMedicineService _mediicineService;
        private readonly IMedicineManager _mediicineManager;
        private readonly IWarehouseManager _warehouseManager;
        private readonly IIssueRequestManager _issueRequestManager;
        private readonly IIssueRequestService _issueRequestService;
        public MedicinesController(IWarehouseManager warehouseManager, IMedicineManager mediicineManager, IMedicineService mediicineService, IIssueRequestManager issueRequestManager, IIssueRequestService issueRequestService)
        {
            _warehouseManager = warehouseManager;
            _mediicineManager = mediicineManager;
            _mediicineService = mediicineService;
            _issueRequestManager = issueRequestManager;
            _issueRequestService = issueRequestService;
        }

        [HttpGet]
        public async Task<IActionResult> GetMedicines(int warehouseId)
        {
            return Ok(await _mediicineService.GetMedicinesAsync(warehouseId));
        }

        [HttpGet("RunningOut")]
        public async Task<IActionResult> GetRunningOutMedicines()
        {
            return Ok(await _mediicineService.GetRunningOutMedicinesAsync());
        }

        [HttpPost("Invoice")]
        public async Task<IActionResult> InvoiceMedicines(MedicineInvoiceDTO medicineInvoice)
        {
            if (medicineInvoice.Medicines.Any(m => m.ExpirationDate < DateTime.Now))
                return BadRequest("Невозможно принять счет, так как в списке встречаются просроченные препараты");

            await _mediicineService.CreateIssueRequestAsync(medicineInvoice);

            return Ok();
        }

        [HttpPost("Writeoff")]
        public async Task<IActionResult> WriteoffMedicines(MedicineWriteoffDTO writeoff)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (writeoff.Quantity <= 0)
                return BadRequest("На остатке меньшее количество, чем вы пытаетесь списать");

            var exists = await _mediicineManager.Exists(writeoff.MedicineId);

            if (!exists)
                return BadRequest("Медицинский препарат с указанным ID не найден");

            var canWriteoff = await _mediicineManager.CanWriteOff(writeoff.MedicineId, writeoff.Quantity);

            if (!canWriteoff)
                return BadRequest("На остатке меньшее количество, чем вы пытаетесь списать");

            await _mediicineService.WriteOffAsync(writeoff);

            return Ok();
        }

        [HttpPost("{medicineId:int}/Transfer")]
        public async Task<IActionResult> TransferMedicines([FromRoute] int medicineId, [FromQuery] int destinationWarehouseId)
        {
            var exists = await _warehouseManager.Exists(destinationWarehouseId);

            if (!exists)
                return NotFound("Склад назначения с указанным Id не найден");

            var hostWarehouse = await _mediicineManager.GetHostWarehouse(medicineId);

            if (hostWarehouse == destinationWarehouseId)
                return BadRequest("Склад назначения совпадает с текущим складом");

            await _mediicineService.TransferAsync(new MedicineTransferDTO()
            {
                MedicineId = medicineId,
                WarehouesId = destinationWarehouseId,
            });

            return Ok();
        }

        [HttpGet("/IssueRequests")]
        public async Task<IActionResult> GetIssueRequest()
        {
            return Ok(await _issueRequestService.GetIssueRequests());
        }

        [HttpGet("/IssueRequests/{requestId:int}")]
        public async Task<IActionResult> GetIssueRequestItems(int requestId)
        {
            return Ok(await _issueRequestService.GetIssueRequestItems(requestId));
        }

        [HttpPut("/IssueRequests/{requestId:int}/Complete")]
        public async Task<IActionResult> CompleteIssueRequest(int requestId)
        {
            var isCompleted = await _issueRequestManager.IsCompleted(requestId);

            if (isCompleted)
                return BadRequest("Заявка на выдачу уже выполнена");

            var response = await _issueRequestManager.CanComplete(requestId);

            if (!response.Success)
                return BadRequest(response.Error);

            await _issueRequestService.CompeleteIssueRequest(requestId);

            return Ok();
        }
    }
}
