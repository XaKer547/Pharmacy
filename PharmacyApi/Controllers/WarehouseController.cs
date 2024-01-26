using Microsoft.AspNetCore.Mvc;
using PharmacyApi.Services.Interfaces;

namespace PharmacyApi.Controllers
{
    [ApiController]
    [Route("[action]")]
    public class WarehouseController : ControllerBase
    {
        private readonly IWarehouseService _warehouseService;
        public WarehouseController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }

        [HttpGet("/Warehouses")]
        public async Task<IActionResult> GetWarehouses()
        {
            return Ok(await _warehouseService.GetWarehousesAsync());
        }
    }
}
