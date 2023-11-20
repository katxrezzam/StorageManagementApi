namespace storageApi;

public class Provider
{
    public int ProviderId { get; set; }
    public string ProviderName { get; set; } = string.Empty;
    public string ProviderAddress { get; set; } = string.Empty;
    public string ProviderPhone { get; set; } = string.Empty;
    public string ProviderWeb { get; set; } = string.Empty;
    public ICollection<Order> Orders { get; set; } = null!;
}
