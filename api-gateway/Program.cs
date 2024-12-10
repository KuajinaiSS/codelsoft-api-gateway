using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Ocelot Configuration Add Here Your ocelot redirection !!!
builder.Configuration.AddJsonFile("Ocelot.json", false, true);
builder.Services.AddOcelot(builder.Configuration);

// Debug Configuration
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.SetMinimumLevel(LogLevel.Debug);

var app = builder.Build();

await app.UseOcelot();

app.Run();