using Microsoft.EntityFrameworkCore;
using PharmacyApi.Data;
using PharmacyApi.Services.Interfaces;

namespace PharmacyApi.Services
{
    public class WarehouseManager : IWarehouseManager
    {
        private readonly PharmacyDbContext _context;
        public WarehouseManager(PharmacyDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Exists(int warehouseId)
        {
            return await _context.Warehouses.AnyAsync(w => w.Id == warehouseId);
        }
    }
}
