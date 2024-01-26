namespace PharmacyApi.Data.Entities
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Medicine> Medicines { get; set; } = new HashSet<Medicine>();
    }
}
