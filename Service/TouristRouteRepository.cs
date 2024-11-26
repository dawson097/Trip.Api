using Trip.Api.Database;
using Trip.Api.Models;
using Trip.Api.Service.Interfaces;

namespace Trip.Api.Service;

public class TouristRouteRepository : ITouristRouteRepository
{
    private readonly AppDbContext _context;

    public TouristRouteRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<TouristRoute> GetAllRoutes()
    {
        return _context.TouristRoutes.ToList();
    }

    public TouristRoute GetRouteByRouteId(Guid routeId)
    {
        return _context.TouristRoutes.FirstOrDefault(route => route.Id == routeId);
    }
}