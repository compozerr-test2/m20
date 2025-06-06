using Carter;
using Microsoft.AspNetCore.Routing;

namespace M20.Endpoints.M20;

public class M20Group : CarterModule
{
    public M20Group() : base("/m20")
    {
        WithTags(nameof(M20));
    }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.AddM20Route();
    }
}