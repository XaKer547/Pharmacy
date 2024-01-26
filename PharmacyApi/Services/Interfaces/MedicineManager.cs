﻿using Microsoft.EntityFrameworkCore;
using PharmacyApi.Data;

namespace PharmacyApi.Services.Interfaces
{
    public class MedicineManager : IMedicineManager
    {
        private readonly PharmacyDbContext _context;
        public MedicineManager(PharmacyDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CanWriteOff(int medicineId, int quantity)
        {
            var medicine = await _context.Medicines.SingleOrDefaultAsync(m => m.Id == medicineId);

            return medicine.StockQuantity - quantity >= 0;
        }

        public async Task<bool> Exists(int medicineId)
        {
            return await _context.Medicines.AnyAsync(m => m.Id == medicineId);
        }
    }
}
