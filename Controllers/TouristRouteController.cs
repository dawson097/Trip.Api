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
        return Ok(await _routeRepository.GetAllRoutesAsync());
    }

    [HttpGet("{routeId:guid}")]
    public async Task<IActionResult> GetTouristRouteAsync(Guid routeId)
    {
        return Ok(await _routeRepository.GetRouteByRouteIdAsync(routeId));
    }
}