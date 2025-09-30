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
app.UseFastEndpoints(c =>
    {
        c.Endpoints.RoutePrefix = "api";
        c.Versioning.Prefix = "v";
        c.Versioning.PrependToRoute = true;
    })
    .UseDefaultExceptionHandler()
    .UseSwaggerGen();

app.Run();