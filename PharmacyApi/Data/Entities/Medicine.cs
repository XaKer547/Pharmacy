namespace PharmacyApi.Data.Entities
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public TradeName TradeName { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int StockQuantity { get; set; }
        public int OptimalQuantity { get; set; }
        public Warehouse Warehouse { get; set; }
    }
}