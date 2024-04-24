using CarterModuleMonolith.ModuleTwo.Domain;
using MediatR;

namespace CarterModuleMonolith.ModuleTwo.Application.Handlers.Query.GetEntityOneById;
public record GetEntityTwoByIdQuery(int Id) : IRequest<EntityTwo>;
