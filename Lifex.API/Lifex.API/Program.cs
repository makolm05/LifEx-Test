using LifEx.API.Helpers;

var builder = WebApplication.CreateBuilder(args);

Startup.ConfigureServices(builder.Configuration, builder.Services);
var app = builder.Build();

Startup.ConfigureApplication(app);
app.Run();