
using PharmacyApi.Data.Entities;
using System.Text.Json;

namespace PharmacyApi.Data.Seeder
{
    public partial class DbSeeder
    {
        public void SeedAll(PharmacyDbContext context)
        {
            SeedWarehouseAsync(context).GetAwaiter().GetResult();

            SeedManufacturerAsync(context).GetAwaiter().GetResult();

            SeedTradeNamesAsync(context).GetAwaiter().GetResult();

            SeedMedicinesAsync(context).GetAwaiter().GetResult();
        }

        private async Task SeedMedicinesAsync(PharmacyDbContext context)
        {
            if (context.Medicines.Any())
                return;

            using var file = new StreamReader("medicines_data.json");
            var json = file.ReadToEnd();
            var medicines = JsonSerializer.Deserialize<IReadOnlyCollection<Medicine>>(json);

            context.Medicines.AddRange(medicines);

            await context.SaveChangesAsync();
        }
    }
}
