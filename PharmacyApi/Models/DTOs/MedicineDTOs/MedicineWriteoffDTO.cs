using System.ComponentModel.DataAnnotations;

namespace PharmacyApi.Models.DTOs.MedicineDTOs
{
    public class MedicineWriteoffDTO
    {
        public int MedicineId { get; set; }
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Причина обязательна для фиксации факта списания")]
        public string Reason { get; set; }
    }
}
