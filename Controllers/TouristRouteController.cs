using Microsoft.AspNetCore.Mvc;
using Trip.Api.Services;

namespace Trip.Api.Controllers;

[Route("api/tourist-routes")]
[ApiController]
public class TouristRouteController : ControllerBase
{
    private readonly ITouristRouteRepository _routeRepository;

    public TouristRouteController(ITouristRouteRepository routeRepository)
    {
        _routeRepository = routeRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetTouristRoutesAsync()
    {
        var routesFromRepo = await _routeRepository.GetAllRoutesAsync();

        if (routesFromRepo == null || routesFromRepo.Count() < 0)
        {
            return NotFound("Cannot found any tourist route");
        }

        return Ok(routesFromRepo);
    }

    [HttpGet("{routeId:guid}")]
    public async Task<IActionResult> GetTouristRouteAsync(Guid routeId)
    {
        var routeFromRepo = await _routeRepository.GetRouteByRouteIdAsync(routeId);

        if (routeFromRepo == null)
        {
            return NotFound($"Cannot found current tourist route, route id is {routeId}");
        }

        return Ok(routeFromRepo);
    }
}