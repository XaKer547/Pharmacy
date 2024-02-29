using PharmacyApi.Data.Entities;
using System.Text.Json;

namespace PharmacyApi.Data.Seeder
{
    public partial class DbSeeder
    {
        public async Task SeedTradeNamesAsync(PharmacyDbContext context)
        {
            if (context.TradeNames.Any())
                return;

            using var file = new StreamReader("trade.json");
            var json = file.ReadToEnd();

            var tradeNames = JsonSerializer.Deserialize<IReadOnlyCollection<TradeName>>(json);

            context.TradeNames.AddRange(tradeNames);

            await context.SaveChangesAsync();
        }
    }
}
