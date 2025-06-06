using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using M20.Services;

namespace M20.Endpoints.M20;

public static class M20Route
{
    public static RouteHandlerBuilder AddM20Route(this IEndpointRouteBuilder app)
    {
        return app.MapGet("/", (string name, IM20Service m20Service) => new GetM20Response($"Hello, {m20Service.GetObfuscatedName(name)}!"));
    }
}