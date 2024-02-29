namespace PharmacyApi.Models.DTOs.MedicineDTOs
{
    public class InvoicedMedicineDTO
    {
        public int Id { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public DateTime ExpirationDate { get; set; }
    }
}