using Microsoft.EntityFrameworkCore;
using Trip.Api.Database;
using Trip.Api.Service;
using Trip.Api.Service.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(options => options.ReturnHttpNotAcceptable = true)
    .AddXmlDataContractSerializerFormatters();

builder.Services.AddTransient<ITouristRouteRepository, TouristRouteRepository>();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("NgSql");

    options.UseNpgsql(connectionString);
});

var app = builder.Build();

app.MapControllers();

app.Run();