using CarterModuleMonolith.ModuleOne.Domain;
using MediatR;

namespace CarterModuleMonolith.ModuleOne.Application.Handlers.Query.GetEntityOneById;
public record GetEntityOneByIdQuery(int Id) : IRequest<EntityOne>;
