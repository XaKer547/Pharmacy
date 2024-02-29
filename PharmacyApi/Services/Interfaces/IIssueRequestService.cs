using PharmacyApi.Models.DTOs.MedicineDTOs;

namespace PharmacyApi.Services.Interfaces
{
    public interface IIssueRequestService
    {
        Task CompeleteIssueRequest(int issueId);
        Task CreateIssueRequestAsync(MedicineInvoiceDTO medicineInvoice);
        Task<IReadOnlyCollection<IssueRequestDTO>> GetIssueRequests();
        Task<IReadOnlyCollection<IssueRequestItemDTO>> GetIssueRequestItems(int issueId);
    }
}
