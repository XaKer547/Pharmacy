using Microsoft.EntityFrameworkCore;
using PharmacyApi.Data;
using PharmacyApi.Models.DTOs.WarehouseDTOs;
using PharmacyApi.Services.Interfaces;

namespace PharmacyApi.Services
{
    public class WarehouseService : IWarehouseService
    {
        private readonly PharmacyDbContext _context;
        public WarehouseService(PharmacyDbContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<Warehouse>> GetWarehousesAsync()
        {
            return await _context.Warehouses.Select(w => new Warehouse
            {
                Id = w.Id,
                Name = w.Name,
            }).ToArrayAsync();
        }
    }
}
