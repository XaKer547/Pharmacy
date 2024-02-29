using Microsoft.EntityFrameworkCore;
using PharmacyApi.Data;
using PharmacyApi.Data.Entities;
using PharmacyApi.Models.DTOs.MedicineDTOs;
using PharmacyApi.Services.Interfaces;

namespace PharmacyApi.Services
{
    public class IssueRequestService : IIssueRequestService
    {
        private readonly PharmacyDbContext _context;
        public IssueRequestService(PharmacyDbContext context)
        {
            _context = context;
        }

        public async Task CompeleteIssueRequest(int issueId)
        {
            var issueRequest = _context.IssueRequests.SingleOrDefault(i => i.Id == issueId);

            if (issueRequest == null)
                return;

            issueRequest.IsCompleted = true;

            _context.IssueRequests.Update(issueRequest);

            await _context.SaveChangesAsync();
        }

        public async Task CreateIssueRequestAsync(MedicineInvoiceDTO medicineInvoice)
        {
            var issueRequest = new IssueRequest()
            {
                CreatedTime = DateTime.Now,
                Purpose = medicineInvoice.Purpose,
                Requests = medicineInvoice.Medicines.Select(m => new Request
                {
                    MedicineId = m.Id,
                    Quantity = m.Quantity,
                }).ToArray(),
            };

            _context.IssueRequests.Add(issueRequest);

            await _context.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<IssueRequestDTO>> GetIssueRequests()
        {
            return await _context.IssueRequests.Select(i => new IssueRequestDTO
            {
                Id = i.Id,
                CreatedTime = i.CreatedTime,
                Purpose = i.Purpose,
            }).ToArrayAsync();
        }

        public async Task<IReadOnlyCollection<IssueRequestItemDTO>> GetIssueRequestItems(int issueId)
        {
            var issueRequest = await _context.IssueRequests.Include(i => i.Requests)
                .SingleOrDefaultAsync(i => i.Id == issueId);

            if (issueRequest == null)
                return null;

            return issueRequest.Requests.Select(r => new IssueRequestItemDTO
            {
                Quantity = r.Quantity,
                Medicine = new MedicinePreviewDTO()
                {
                    id = r.MedicineId,
                    Name = r.Medicine.Name,
                    Image = r.Medicine.Image,
                }
            }).ToArray();
        }
    }
}
