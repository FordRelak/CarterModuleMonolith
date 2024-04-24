using Carter;
using Carter.OpenApi;
using CarterModuleMonolith.ModuleTwo.Web.Features.EntityTwo.Routes;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace CarterModuleMonolith.ModuleTwo.Web.Features.EntityTwo;
internal class EntityTwoModule : CarterModule, ICarterModule
{
    public EntityTwoModule() : base("/entity-two")
    {

    }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/{id:int}", GetEntityTwoByIdRoute.Handle)
           .Produces<EntityTwoEntity>(StatusCodes.Status200OK)
           .AllowAnonymous()
           .IncludeInOpenApi();
    }
}
