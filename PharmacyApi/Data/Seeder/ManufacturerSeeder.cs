using PharmacyApi.Data.Entities;
using System.Text.Json;

namespace PharmacyApi.Data.Seeder
{
    public partial class DbSeeder
    {
        public async Task SeedManufacturerAsync(PharmacyDbContext context)
        {
            if (context.Manufacturers.Any())
                return;

            using var file = new StreamReader("trade.json");
            var json = file.ReadToEnd();

            var manufacturers = JsonSerializer.Deserialize<IReadOnlyCollection<Manufacturer>>(json);

            context.Manufacturers.AddRange(manufacturers);

            await context.SaveChangesAsync();
        }
    }
}
