namespace storageApi;

public interface ITransferRepository
{
    Task<ICollection<Transfer>> GetTransfers();
    Task<Transfer?> GetTransfer(int transferId);
    Task<bool> TransferExists(int transferId);
    Task<bool> CreateTransfer(Transfer transfer);
    Task<bool> RemoveTransfer(Transfer transfer);
    Task<bool> UpdateTransfer(Transfer transfer);
    Task<bool> Save();
}
