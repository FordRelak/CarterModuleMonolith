using Carter.ModelBinding;
using Carter.Response;
using CarterModuleMonolith.ModuleTwo.Application.Handlers.Query.GetEntityOneById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CarterModuleMonolith.ModuleTwo.Web.Features.EntityTwo.Routes;

internal class GetEntityTwoByIdRoute
{
    public static async Task Handle(
        [FromRoute] int id,
        [FromServices] IMediator mediator,
        [FromServices] ILogger<GetEntityTwoByIdRoute> logger,
        HttpContext context,
        HttpResponse response,
        CancellationToken cancellationToken)
    {
        var request = new GetEntityTwoByIdQuery(id);
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
