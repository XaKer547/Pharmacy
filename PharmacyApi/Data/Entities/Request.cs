using System.ComponentModel.DataAnnotations.Schema;

namespace PharmacyApi.Data.Entities
{
    public class Request
    {
        public int MedicineId { get; set; }

        [ForeignKey(nameof(MedicineId))]
        public Medicine Medicine { get; set; }
        public int Quantity { get; set; }
    }
}