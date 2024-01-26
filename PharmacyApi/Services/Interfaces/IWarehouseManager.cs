namespace PharmacyApi.Services.Interfaces
{
    public interface IWarehouseManager
    {
        Task<bool> Exists(int warehouseId);
    }
}
