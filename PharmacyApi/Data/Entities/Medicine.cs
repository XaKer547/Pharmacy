using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyApi.Data.Entities
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TradeNameId { get; set; }
        [ForeignKey(nameof(TradeNameId))]
        public TradeName TradeName { get; set; }
        public int ManufacturerId { get; set; }
        [ForeignKey(nameof(ManufacturerId))]
        public Manufacturer Manufacturer { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int StockQuantity { get; set; }
        public int OptimalQuantity { get; set; }
        public int WarehouseId { get; set; }
        [ForeignKey(nameof(WarehouseId))]
        public Warehouse Warehouse { get; set; }
    }
}