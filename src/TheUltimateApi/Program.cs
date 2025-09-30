using Application;
using Domain;
using FastEndpoints;
using FastEndpoints.Swagger;
using Infrastructure;
using TheUltimateApi;

var builder = WebApplication.CreateBuilder(args);

// configure clean architecture
builder.Services
    .ConfigurePresentation()
    .ConfigureApplication()
    .ConfigureDomain()
    .ConfigureInfrastructure();

var app = builder.Build();

// Use FastEndpoints fff
app.UseFastEndpoints()
    .UseDefaultExceptionHandler()
    .UseSwaggerGen();

app.Run();