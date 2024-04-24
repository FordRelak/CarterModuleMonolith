using Carter;
using CarterModuleMonolith.ModuleTwo.Application.Handlers.Query.GetEntityOneById;
using CarterModuleMonolith.ModuleTwo.Web.Features.EntityTwo;
using Microsoft.Extensions.DependencyInjection;

namespace CarterModuleMonolith.ModuleTwo;
public static class ModuleTwo
{
    public static IServiceCollection AddModuleTwo(this IServiceCollection services)
    {
        services.AddCarter(configurator: c =>
        {
            c.WithValidatorLifetime(ServiceLifetime.Scoped);
            c.WithModules(typeof(EntityTwoModule));
            c.WithValidators(typeof(GetEntityTwoByIdQueryValidator));
        });

        services.AddMediatR(c => c.RegisterServicesFromAssemblyContaining<EntityTwoModule>());

        return services;
    }
}
