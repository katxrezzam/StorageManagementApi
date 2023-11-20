
using Microsoft.EntityFrameworkCore;

namespace storageApi;

public class LocationRepository(DataContext context) : ILocationRepository
{
    private readonly DataContext _context = context;

    public async Task<bool> CreateLocation(Location location)
    {
        _context.Locations.Add(location);
        return await Save();
    }

    public async Task<Location?> GetLocation(int locationId)
    {
        return await _context.Locations.FindAsync(locationId);
    }

    public async Task<ICollection<Location>> GetLocations()
    {
        return await _context.Locations.ToListAsync();
    }

    public async Task<bool> LocationExists(int locationId)
    {
        return await _context.Locations.AnyAsync(l => l.LocationId == locationId);
    }

    public async Task<bool> RemoveLocation(Location location)
    {
        _context.Locations.Add(location);
        return await Save();
    }

    public async Task<bool> Save()
    {
        return await _context.SaveChangesAsync() > 0;
    }

    public async Task<bool> UpdateLocation(Location location)
    {
        _context.Locations.Add(location);
        return await Save();
    }
}
