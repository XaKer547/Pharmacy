using Microsoft.EntityFrameworkCore;
using PharmacyApi.Data;
using PharmacyApi.Models.DTOs.MedicineDTOs;
using PharmacyApi.Services.Interfaces;

namespace PharmacyApi.Services
{
    public partial class MedicineService : IMedicineService
    {
        private readonly PharmacyDbContext _context;
        public MedicineService(PharmacyDbContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<Medicine>> GetMedicinesAsync(int warehouseId)
        {
            return await _context.Medicines.Select(m => new Medicine
            {
                Id = m.Id,
                Name = m.Name,
                TradeName = m.TradeName.Name,
                Manufacturer = m.Manufacturer.Name,
                Image = m.Image,
                Price = m.Price,
                StockQuantity = m.StockQuantity,
                WarehouseId = m.Warehouse.Id
            }).ToArrayAsync();
        }

        public async Task<IReadOnlyCollection<RunningOutMedicines>> GetRunningOutMedicinesAsync()
        {
            return await _context.Medicines.Select(m => new RunningOutMedicines
            {
                Id = m.Id,
                Name = m.Name,
                Manufacturer = m.Manufacturer.Name,
                Image = m.Image,
                Price = m.Price,
                StockQuantity = m.StockQuantity,
                OptimalQuantity = m.OptimalQuantity,
            }).Where(m => m.StockQuantity < m.OptimalQuantity)
            .ToArrayAsync();
        }

        public async Task TransferAsync(MedicineTransfer transfer)
        {
            var medicine = _context.Medicines.Include(m => m.Warehouse)
                .SingleOrDefault(m => m.Id == transfer.MedicineId);

            await _context.SaveChangesAsync();
        }

        public async Task WriteOffAsync(MedicineWriteoff writeoff)
        {
            var medicine = _context.Medicines.SingleOrDefault(m => m.Id == writeoff.MedicineId);



        }
    }
}
