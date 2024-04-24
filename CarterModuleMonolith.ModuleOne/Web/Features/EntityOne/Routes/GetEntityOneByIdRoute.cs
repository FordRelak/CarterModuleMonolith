using Carter.ModelBinding;
using Carter.Response;
using CarterModuleMonolith.ModuleOne.Application.Handlers.Query.GetEntityOneById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CarterModuleMonolith.ModuleOne.Web.Features.EntityOne.Routes;

internal class GetEntityOneByIdRoute
{
    public static async Task Handle(
        [FromRoute] int id,
        [FromServices] IMediator mediator,
        [FromServices] ILogger<GetEntityOneByIdRoute> logger,
        HttpContext context,
        HttpResponse response,
        CancellationToken cancellationToken)
    {
        var request = new GetEntityOneByIdQuery(id);
        var validationResult = context.Request.Validate(request);

        if(validationResult != null)
        {
            var modelError = validationResult.GetFormattedErrors().First();
            logger.LogError("{prop} - {mes}", modelError.PropertyName, modelError.ErrorMessage);
        }

        var entityOne = await mediator.Send(request, cancellationToken);

        await response.Negotiate(entityOne, cancellationToken);
    }
}