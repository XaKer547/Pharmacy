namespace PharmacyApi.Models.DTOs.MedicineDTOs
{
    public class MedicineInvoiceDTO
    {
        public DateTime DocumentDate { get; set; }
        public string Purpose { get; set; }
        public string Provider { get; set; }
        public IReadOnlyCollection<InvoicedMedicineDTO> Medicines { get; set; }
    }
}
