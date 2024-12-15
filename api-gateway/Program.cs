using api_gateway.Microservices.Extensions;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("Ocelot.json", false, true);
builder.Services.AddOcelot(builder.Configuration);

builder.Services.AddEndpointsApiExplorer();

// Debug Configuration
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.SetMinimumLevel(LogLevel.Debug);

// Add Services
builder.Services.AddApplicationServices(builder.Configuration);

var app = builder.Build();

await app.UseOcelot();

// Add Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Add Https
app.UseHttpsRedirection();

// Add Controllers
app.MapControllers();

app.Run();