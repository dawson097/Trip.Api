using Microsoft.EntityFrameworkCore;
using Trip.Api.Database;
using Trip.Api.Entities;

namespace Trip.Api.Services;

public class TouristRouteRepository : ITouristRouteRepository
{
    private readonly TripDbContext _context;

    public TouristRouteRepository(TripDbContext context)
    {
        _context = context;
    }

    public async Task<List<TouristRoute>> GetAllRoutesAsync()
    {
        return await _context.TouristRoutes.ToListAsync();
    }

    public async Task<TouristRoute> GetRouteByRouteIdAsync(Guid routeId)
    {
        return await _context.TouristRoutes.FirstOrDefaultAsync(route => route.Id == routeId);
    }
}