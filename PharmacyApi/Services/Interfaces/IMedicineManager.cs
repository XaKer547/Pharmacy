namespace PharmacyApi.Services.Interfaces
{
    public interface IMedicineManager
    {
        Task<bool> CanWriteOff(int medicineId, int quantity);
        Task<bool> Exists(int medicineId);
        Task<int> GetHostWarehouse(int medicineId);
    }
}
