using Microsoft.AspNetCore.Mvc;
using PharmacyApi.Services.Interfaces;

namespace PharmacyApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class MedicinesController : ControllerBase
    {
        private readonly IMedicineService _mediicineService;
        private readonly IMedicineManager _mediicineManager;
        private readonly IWarehouseManager _warehouseManager;
        public MedicinesController(IWarehouseManager warehouseManager, IMedicineManager mediicineManager, IMedicineService mediicineService)
        {
            _warehouseManager = warehouseManager;
            _mediicineManager = mediicineManager;
            _mediicineService = mediicineService;
        }

        [HttpGet("{WarehouseId}")]
        public async Task<IActionResult> GetMedicines(int warehouseId)
        {
            return Ok(await _mediicineService.GetMedicinesAsync(warehouseId));
        }

        [HttpGet("RunningOut")]
        public async Task<IActionResult> GetRunningOutMedicines()
        {
            return Ok(await _mediicineService.GetRunningOutMedicinesAsync());
        }
    }
}
