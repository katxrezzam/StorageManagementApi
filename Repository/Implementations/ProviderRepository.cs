
using Microsoft.EntityFrameworkCore;

namespace storageApi;

public class ProviderRepository(DataContext context) : IProviderRepository
{
    private readonly DataContext _context = context;

    public async Task<bool> CreateProvider(Provider provider)
    {
        _context.Providers.Add(provider);
        return await Save();
    }

    public async Task<Provider?> GetProvider(int providerId)
    {
        return await _context.Providers.FindAsync(providerId);
    }

    public async Task<ICollection<Provider>> GetProviders()
    {
        return await _context.Providers.ToListAsync();
    }

    public async Task<bool> ProviderExists(int providerId)
    {
        return await _context.Providers.AnyAsync(p => p.ProviderId == providerId);
    }

    public async Task<bool> RemoveProvider(Provider provider)
    {
        _context.Providers.Remove(provider);
        return await Save();
    }

    public async Task<bool> Save()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> UpdateProvider(Provider provider)
    {
        _context.Providers.Update(provider);
        return await Save();
    }
}
