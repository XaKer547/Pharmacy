using PharmacyApi.Data.Entities;
using System.Text.Json;

namespace PharmacyApi.Data.Seeder
{
    public partial class DbSeeder
    {
        public async Task SeedWarehouseAsync(PharmacyDbContext context)
        {
            if (context.Warehouses.Any())
                return;

            using var file = new StreamReader("warehouse.json");
            var json = file.ReadToEnd();

            var warehouses = JsonSerializer.Deserialize<IReadOnlyCollection<Warehouse>>(json);

            context.Warehouses.AddRange(warehouses);

            await context.SaveChangesAsync();
        }
    }
}
