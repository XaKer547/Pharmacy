using Microsoft.EntityFrameworkCore;
using PharmacyApi.Data.Entities;

namespace PharmacyApi.Data
{
    public class PharmacyDbContext : DbContext
    {
        public PharmacyDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<TradeName> TradeNames { get; set; }
    }
}