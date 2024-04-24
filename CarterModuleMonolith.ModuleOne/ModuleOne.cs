using Carter;
using CarterModuleMonolith.ModuleOne.Application.Handlers.Query.GetEntityOneById;
using CarterModuleMonolith.ModuleOne.Web.Features.EntityOne;
using Microsoft.Extensions.DependencyInjection;

namespace CarterModuleMonolith.ModuleOne;
public static class ModuleOne
{
    public static IServiceCollection AddModuleOne(this IServiceCollection services)
    {
        services.AddCarter(configurator: c =>
        {
            c.WithValidatorLifetime(ServiceLifetime.Scoped);
            c.WithModules(typeof(EntityOneModule));
            c.WithValidators(typeof(GetEntityOneByIdQueryValidator));
        });

        services.AddMediatR(c => c.RegisterServicesFromAssemblyContaining<EntityOneModule>());

        return services;
    }
}
