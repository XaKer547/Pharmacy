using System.Text.Json;

namespace PharmacyApi.Data.Entities.Seeder
{
    public partial class DbSeeder
    {
        public async Task SeedManufacturerAsync(PharmacyDbContext context)
        {
            if (context.Manufacturers.Any())
                return;

            var json = "[\r\n    {\r\n        \"id\": 1,\r\n        \"Name\": \"Interfax\"\r\n    },\r\n    {\r\n        \"id\": 2,\r\n        \"Name\": \"Pharmstandard\"\r\n    },\r\n    {\r\n        \"id\": 3,\r\n        \"Name\": \"NPO Materia Me\"\r\n    },\r\n    {\r\n        \"id\": 4,\r\n        \"Name\": \"Reckitt Benckise\"\r\n    },\r\n    {\r\n        \"id\": 5,\r\n        \"Name\": \"GlaxoSmithKline\"\r\n    },\r\n    {\r\n        \"id\": 6,\r\n        \"Name\": \"Novartis\"\r\n    },\r\n    {\r\n        \"id\": 7,\r\n        \"Name\": \"Sanofi\"\r\n    },\r\n    {\r\n        \"id\": 8,\r\n        \"Name\": \"Sandoz\"\r\n    },\r\n    {\r\n        \"id\": 9,\r\n        \"Name\": \"Bayer AG\"\r\n    },\r\n    {\r\n        \"id\": 10,\r\n        \"Name\": \"Schering-Plough\"\r\n    },\r\n    {\r\n        \"id\": 11,\r\n        \"Name\": \"AstraZeneca\"\r\n    },\r\n    {\r\n        \"id\": 12,\r\n        \"Name\": \"Berlin-Chemie\"\r\n    },\r\n    {\r\n        \"id\": 13,\r\n        \"Name\": \"Egis Pharmaceut\"\r\n    },\r\n    {\r\n        \"id\": 14,\r\n        \"Name\": \"Lek Pharmaceuti\"\r\n    },\r\n    {\r\n        \"id\": 15,\r\n        \"Name\": \"Krewel Meuselba\"\r\n    }\r\n]";

            var manufacturers = JsonSerializer.Deserialize<IReadOnlyCollection<Manufacturer>>(json);

            context.Manufacturers.AddRange(manufacturers);

            await context.SaveChangesAsync();
        }
    }
}
