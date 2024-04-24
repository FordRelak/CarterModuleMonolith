using CarterModuleMonolith.ModuleTwo.Domain;
using MediatR;

namespace CarterModuleMonolith.ModuleTwo.Application.Handlers.Query.GetEntityOneById;
internal class GetEntityTwoByIdQueryHandler : IRequestHandler<GetEntityTwoByIdQuery, EntityTwo>
{
    public Task<EntityTwo> Handle(GetEntityTwoByIdQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(EntityTwo.Create(request.Id));
    }
}
