namespace PharmacyApi.Models.DTOs.MedicineDTOs
{
    public class IssueRequestItemDTO
    {
        public int Quantity { get; set; }
        public MedicinePreviewDTO Medicine { get; set; }
    }
}
