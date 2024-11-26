using Microsoft.EntityFrameworkCore;
using Trip.Api.Database;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    var connectionString = builder.Configuration.GetConnectionString("NgSql");

    options.UseNpgsql(connectionString);
});

var app = builder.Build();

app.MapControllers();

app.Run();