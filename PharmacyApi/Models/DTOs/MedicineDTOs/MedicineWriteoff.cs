namespace PharmacyApi.Models.DTOs.MedicineDTOs
{
    public class MedicineWriteoff
    {
        public int MedicineId { get; set; }
        public string Quantity { get; set; }
        public string Reason { get; set; }
    }
}
