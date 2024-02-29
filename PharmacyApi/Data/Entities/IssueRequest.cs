namespace PharmacyApi.Data.Entities
{
    public class IssueRequest
    {
        public int Id { get; set; }
        public string Purpose { get; set; }
        public DateTime CreatedTime { get; set; }
        public ICollection<Request> Requests { get; set; }
        public bool IsCompleted { get; set; }
    }
}
