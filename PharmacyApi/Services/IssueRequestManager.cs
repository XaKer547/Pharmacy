using Microsoft.EntityFrameworkCore;
using PharmacyApi.Data;
using PharmacyApi.Models;
using PharmacyApi.Services.Interfaces;

namespace PharmacyApi.Services
{
    public class IssueRequestManager : IIssueRequestManager
    {
        private readonly PharmacyDbContext _context;
        public IssueRequestManager(PharmacyDbContext context)
        {
            _context = context;
        }

        public async Task<ServiceResponse> CanComplete(int issueId)
        {
            var issueRequest = await _context.IssueRequests.Include(i => i.Requests)
                .SingleOrDefaultAsync(i => i.Id == issueId);

            if (issueRequest == null)
                return new ServiceResponse()
                {
                    Error = ""
                };

            var request = issueRequest.Requests.FirstOrDefault(r => r.Medicine.StockQuantity < r.Quantity);

            if (request != null)
                return new ServiceResponse()
                {
                    Error = $"Невозможно выполнить заявку прямо сейчас, так как не хватает препарата с Id={request.MedicineId}" +
                    $" (запрашивается {request.Quantity} шт., а в наличии только {request.Medicine.StockQuantity} шт.)"
                };

            return new ServiceResponse();
        }

        public async Task<bool> IsCompleted(int issueId)
        {
            var issueRequest = await _context.IssueRequests.SingleOrDefaultAsync(i => i.Id == issueId);

            if (issueRequest == null)
                return false;

            return issueRequest.IsCompleted;
        }
    }
}
