using Carter;
using Carter.OpenApi;
using CarterModuleMonolith.ModuleOne.Web.Features.EntityOne.Routes;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace CarterModuleMonolith.ModuleOne.Web.Features.EntityOne;
internal class EntityOneModule : CarterModule, ICarterModule
{
    public EntityOneModule() : base("/entity-one")
    {

    }

    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/{id:int}", GetEntityOneByIdRoute.Handle)
           .Produces<EntityOneEntity>(StatusCodes.Status200OK)
           .AllowAnonymous()
           .IncludeInOpenApi();
    }
}
