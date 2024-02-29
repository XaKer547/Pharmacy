using PharmacyApi.Models;

namespace PharmacyApi.Services.Interfaces
{
    public interface IIssueRequestManager
    {
        Task<bool> IsCompleted(int issueId);
        Task<ServiceResponse> CanComplete(int issueId);
    }
}
