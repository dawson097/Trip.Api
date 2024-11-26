using Trip.Api.Models;

namespace Trip.Api.Service.Interfaces;

/// <summary>
/// Repository service of tourist route
/// </summary>
public interface ITouristRouteRepository
{
    /// <summary>
    /// Get all tourist routes
    /// </summary>
    /// <returns></returns>
    IEnumerable<TouristRoute> GetAllRoutes();

    /// <summary>
    /// Get single tourist route
    /// </summary>
    /// <param name="routeId"></param>
    /// <returns></returns>
    TouristRoute GetRouteByRouteId(Guid routeId);
}