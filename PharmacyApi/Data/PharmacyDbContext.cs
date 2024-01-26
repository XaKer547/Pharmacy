using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using PharmacyApi.Data.Entities;

namespace PharmacyApi.Data
{
    public class PharmacyDbContext : DbContext
    {
        private string _tenantIdKey;
        public PharmacyDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<TradeName> TradeNames { get; set; }

        public string TenantID
        {
            get
            {
                var tenantRequest = this.GetService<TenantRequest>();
                return tenantRequest.TenantID;
            }

            set
            {
                _tenantIdKey = value;
            }
        }
    }
}
