



using HouyarRealState.Application;
using HouyarRealState.Infrastructure;
using HouyarRealState.Infrastructure.Middlewares;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddPresentationServices();
builder.Services.AddApplicationServices();
builder.Services.AddInfrastructureServices(builder.Configuration);

var app = builder.Build();
app.ConfigurePipelines();
app.ConfigurePipelines();
app.UseLoggin();
await app.ApplyMigrationsAsync();
app.Run();