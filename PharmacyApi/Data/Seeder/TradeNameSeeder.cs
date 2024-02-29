using System.Text.Json;

namespace PharmacyApi.Data.Entities.Seeder
{
    public partial class DbSeeder
    {
        public async Task SeedTradeNamesAsync(PharmacyDbContext context)
        {
            if (context.TradeNames.Any())
                return;

            var json = "[\r\n    {\r\n        \"id\": 1,\r\n        \"Name\": \"Amiksin\"\r\n    },\r\n    {\r\n        \"id\": 2,\r\n        \"Name\": \"Arbidol\"\r\n    },\r\n    {\r\n        \"id\": 3,\r\n        \"Name\": \"Anaferon\"\r\n    },\r\n    {\r\n        \"id\": 4,\r\n        \"Name\": \"Cycloferon\"\r\n    },\r\n    {\r\n        \"id\": 5,\r\n        \"Name\": \"Remantadin\"\r\n    },\r\n    {\r\n        \"id\": 6,\r\n        \"Name\": \"Kagocel\"\r\n    },\r\n    {\r\n        \"id\": 7,\r\n        \"Name\": \"Ibuprofen\"\r\n    },\r\n    {\r\n        \"id\": 8,\r\n        \"Name\": \"Nurofen\"\r\n    },\r\n    {\r\n        \"id\": 9,\r\n        \"Name\": \"Panadol\"\r\n    },\r\n    {\r\n        \"id\": 10,\r\n        \"Name\": \"Theraflu\"\r\n    },\r\n    {\r\n        \"id\": 11,\r\n        \"Name\": \"Fervex\"\r\n    },\r\n    {\r\n        \"id\": 12,\r\n        \"Name\": \"Amoxicillin\"\r\n    },\r\n    {\r\n        \"id\": 13,\r\n        \"Name\": \"Ciprofloxacin\"\r\n    },\r\n    {\r\n        \"id\": 14,\r\n        \"Name\": \"Claritin\"\r\n    },\r\n    {\r\n        \"id\": 15,\r\n        \"Name\": \"Prilosec\"\r\n    },\r\n    {\r\n        \"id\": 16,\r\n        \"Name\": \"Mezim\"\r\n    },\r\n    {\r\n        \"id\": 17,\r\n        \"Name\": \"Suprastin\"\r\n    },\r\n    {\r\n        \"id\": 18,\r\n        \"Name\": \"No-Shpa\"\r\n    },\r\n    {\r\n        \"id\": 19,\r\n        \"Name\": \"Linex\"\r\n    },\r\n    {\r\n        \"id\": 20,\r\n        \"Name\": \"Valocordin\"\r\n    },\r\n    {\r\n        \"id\": 21,\r\n        \"Name\": \"Bayer\"\r\n    },\r\n    {\r\n        \"id\": 22,\r\n        \"Name\": \"Festal\"\r\n    }\r\n]";

            var tradeNames = JsonSerializer.Deserialize<IReadOnlyCollection<TradeName>>(json);

            context.TradeNames.AddRange(tradeNames);

            await context.SaveChangesAsync();
        }
    }
}
