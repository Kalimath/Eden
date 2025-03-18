using MbDevelopment.Eden.BotanicalAPI;
using MbDevelopment.Eden.DataAccess.Botanical;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddCqrs();
services.AddValidation();
services.AddControllers();
//services.AddRepositories();
services.AddSwaggerGen();
services.AddDbContext<BotanicalContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration.GetConnectionString("localDb"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();
        
app.UseAuthorization();
app.UseEndpoints(routeBuilder => routeBuilder.MapControllers());
app.Run();

namespace MbDevelopment.Eden.BotanicalAPI
{
    record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
    {
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    }
}