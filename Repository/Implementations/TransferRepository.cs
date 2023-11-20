
using Microsoft.EntityFrameworkCore;

namespace storageApi;

public class TransferRepository(DataContext context) : ITransferRepository
{
    private readonly DataContext _context = context;

    public async Task<bool> CreateTransfer(Transfer transfer)
    {
        _context.Transfers.Add(transfer);
        return await Save();
    }

    public async Task<Transfer?> GetTransfer(int transferId)
    {
        return await _context.Transfers.FindAsync(transferId);
    }

    public async Task<ICollection<Transfer>> GetTransfers()
    {
        return await _context.Transfers.ToListAsync();
    }

    public async Task<bool> RemoveTransfer(Transfer transfer)
    {
        _context.Transfers.Remove(transfer);
        return await Save();
    }

    public async Task<bool> Save()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> TransferExists(int transferId)
    {
        return await _context.Transfers.AnyAsync(t => t.TransferId == transferId);
    }

    public async Task<bool> UpdateTransfer(Transfer transfer)
    {
        _context.Transfers.Update(transfer);
        return await Save();
    }
}
