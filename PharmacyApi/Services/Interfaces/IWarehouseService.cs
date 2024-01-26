using PharmacyApi.Models.DTOs.WarehouseDTOs;

namespace PharmacyApi.Services.Interfaces
{
    public interface IWarehouseService
    {
        Task<IReadOnlyCollection<Warehouse>> GetWarehousesAsync();
    }
}
