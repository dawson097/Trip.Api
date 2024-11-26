using Microsoft.EntityFrameworkCore;
using Trip.Api.Database;
using Trip.Api.Models;
using Trip.Api.Service.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddTransient<ITouristRouteRepository, ITouristRouteRepository>();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("NgSql");

    options.UseNpgsql(connectionString);
});

var app = builder.Build();

app.MapControllers();

app.Run();