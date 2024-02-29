namespace PharmacyApi.Models.DTOs.MedicineDTOs
{
    public class IssueRequestDTO
    {
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public string Purpose { get; set; }
    }
}
