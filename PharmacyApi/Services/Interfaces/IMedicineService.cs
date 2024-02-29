using PharmacyApi.Models;
using PharmacyApi.Models.DTOs.MedicineDTOs;

namespace PharmacyApi.Services.Interfaces
{
    public interface IMedicineService
    {
        Task<IReadOnlyCollection<MedicineDTO>> GetMedicinesAsync(int warehouseId);
        Task<IReadOnlyCollection<RunningOutMedicineDTO>> GetRunningOutMedicinesAsync();
        Task WriteOffAsync(MedicineWriteoffDTO writeoff);
        Task TransferAsync(MedicineTransferDTO transfer);
    }
}
