using Microsoft.AspNetCore.Mvc;
using Trip.Api.Service.Interfaces;

namespace Trip.Api.Controllers;

[Route("api/tourist-routes")]
[ApiController]
public class TouristRoutesController : ControllerBase
{
    private readonly ITouristRouteRepository _routeRepository;

    public TouristRoutesController(ITouristRouteRepository routeRepository)
    {
        _routeRepository = routeRepository;
    }

    [HttpGet]
    public IActionResult GetTouristRoutes()
    {
        var routesFromRepo = _routeRepository.GetAllRoutes();

        if (routesFromRepo == null || !routesFromRepo.Any()) return NotFound("Cannot found any routes!");

        return Ok(routesFromRepo);
    }

    [HttpGet("{routeId:guid}")]
    public IActionResult GetTouristRoute(Guid routeId)
    {
        var routeFromRepo = _routeRepository.GetRouteByRouteId(routeId);

        if (routeFromRepo == null) return NotFound($"Current route not found, route id is {routeId}");

        return Ok(routeFromRepo);
    }
}