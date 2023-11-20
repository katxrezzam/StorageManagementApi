namespace storageApi;

public interface IProviderRepository
{
    Task<ICollection<Provider>> GetProviders();
    Task<Provider?> GetProvider(int providerId);
    Task<bool> ProviderExists(int providerId);
    Task<bool> CreateProvider(Provider provider);
    Task<bool> RemoveProvider(Provider provider);
    Task<bool> UpdateProvider(Provider provider);
    Task<bool> Save();
}
