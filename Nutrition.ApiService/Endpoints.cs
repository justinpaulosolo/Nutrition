using Nutrition.ApiService.Common;
using Nutrition.ApiService.Weather;

namespace Nutrition.ApiService;

public static class Endpoints
{
    public static void MapEndpoints(this WebApplication app)
    {
        var endpoint = app.MapGroup("");
        endpoint.MapWeatherEndpoint();
    }

    private static void MapWeatherEndpoint(this IEndpointRouteBuilder app)
    {
        var endpoints = app.MapGroup("/weatherforecast");

        endpoints.MapPublicGroup()
            .MapEndpoint<GetWeather>();
    }

    private static RouteGroupBuilder MapPublicGroup(this IEndpointRouteBuilder app, string? prefix = null)
    {
        return app.MapGroup(prefix ?? string.Empty)
            .AllowAnonymous();
    }

    private static RouteGroupBuilder MapAuthorizedGroup(this IEndpointRouteBuilder app, string? prefix = null)
    {
        return app.MapGroup(prefix ?? string.Empty)
            .RequireAuthorization();
    }

    private static IEndpointRouteBuilder MapEndpoint<TEndpoint>(this IEndpointRouteBuilder app) where TEndpoint : IEndpoint
    {
        TEndpoint.Map(app);
        return app;
    }
}
