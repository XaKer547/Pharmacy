using Microsoft.EntityFrameworkCore;
using PharmacyApi.Data;
using PharmacyApi.Data.Entities;
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

        public async Task<IReadOnlyCollection<MedicineDTO>> GetMedicinesAsync(int warehouseId)
        {
            return await _context.Medicines.Select(m => new Models.DTOs.MedicineDTOs.MedicineDTO
            {
                Id = m.Id,
                Name = m.Name,
                TradeName = m.TradeName.Name,
                Manufacturer = m.Manufacturer.Name,
                Image = m.Image,
                Price = m.Price,
                StockQuantity = m.StockQuantity,
                WarehouseId = m.Warehouse.Id,
            }).ToArrayAsync();
        }

        public async Task<IReadOnlyCollection<RunningOutMedicineDTO>> GetRunningOutMedicinesAsync()
        {
            return await _context.Medicines.Select(m => new RunningOutMedicineDTO
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

        public async Task TransferAsync(MedicineTransferDTO transfer)
        {
            var medicine = _context.Medicines.Include(m => m.Warehouse)
                .SingleOrDefault(m => m.Id == transfer.MedicineId);

            if (medicine == null)
                return;

            medicine.WarehouseId = transfer.WarehouesId;

            _context.Medicines.Update(medicine);

            await _context.SaveChangesAsync();
        }

        public async Task WriteOffAsync(MedicineWriteoffDTO writeoff)
        {
            var medicine = _context.Medicines.SingleOrDefault(m => m.Id == writeoff.MedicineId);

            if (medicine == null)
                return;

            medicine.StockQuantity -= writeoff.Quantity;

            _context.Medicines.Update(medicine);

            await _context.SaveChangesAsync();
        }
    }
}
