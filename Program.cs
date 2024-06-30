using Microsoft.EntityFrameworkCore;
using Trip.Api.Database;
using Trip.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// 添加服务至容器中
builder.Services.AddControllers();

builder.Services.AddTransient<ITouristRouteRepository, TouristRouteRepository>();

builder.Services.AddDbContext<TripDbContext>(options =>
{
    var connStr = builder.Configuration.GetConnectionString("MySql");

    options.UseMySql(connStr, MySqlServerVersion.LatestSupportedServerVersion);
});

var app = builder.Build();

app.MapControllers();

app.Run();