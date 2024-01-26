using PharmacyApi.Models.DTOs.MedicineDTOs;

namespace PharmacyApi.Services.Interfaces
{
    public interface IMedicineService
    {
        Task<IReadOnlyCollection<Medicine>> GetMedicinesAsync(int warehouseId);
        Task<IReadOnlyCollection<RunningOutMedicines>> GetRunningOutMedicinesAsync();
        Task WriteOffAsync(MedicineWriteoff writeoff);
        Task TransferAsync(MedicineTransfer transfer);
    }
}
