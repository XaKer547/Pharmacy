namespace PharmacyApi.Models
{
    public class ServiceResponse
    {
        public string? Error { get; set; }
        public bool Success => Error != null;
    }
}
