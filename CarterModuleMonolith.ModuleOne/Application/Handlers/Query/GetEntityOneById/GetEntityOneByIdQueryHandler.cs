using CarterModuleMonolith.ModuleOne.Domain;
using MediatR;

namespace CarterModuleMonolith.ModuleOne.Application.Handlers.Query.GetEntityOneById;
internal class GetEntityOneByIdQueryHandler : IRequestHandler<GetEntityOneByIdQuery, EntityOne>
{
    public Task<EntityOne> Handle(GetEntityOneByIdQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult(EntityOne.Create(request.Id));
    }
}
