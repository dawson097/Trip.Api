using Trip.Api.Entities;

namespace Trip.Api.Services;

/// <summary>
/// 旅游路线服务
/// </summary>
public interface ITouristRouteRepository
{
    /// <summary>
    /// 获取所有旅游路线
    /// </summary>
    /// <returns></returns>
    Task<List<TouristRoute>> GetAllRoutesAsync();

    /// <summary>
    /// 获取单个旅游路线
    /// </summary>
    /// <param name="routeId">旅游路线id</param>
    /// <returns></returns>
    Task<TouristRoute> GetRouteByRouteIdAsync(Guid routeId);
}