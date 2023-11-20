namespace storageApi;

public interface ILocationRepository
{
Task<ICollection<Location>> GetLocations();
    Task<Location?> GetLocation(int locationId);
    Task<bool> LocationExists(int locationId);
    Task<bool> CreateLocation(Location location);
    Task<bool> RemoveLocation(Location location);
    Task<bool> UpdateLocation(Location location);
    Task<bool> Save();
}
