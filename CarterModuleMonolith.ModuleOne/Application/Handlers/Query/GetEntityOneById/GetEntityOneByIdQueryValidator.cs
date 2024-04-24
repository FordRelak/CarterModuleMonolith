using FluentValidation;

namespace CarterModuleMonolith.ModuleOne.Application.Handlers.Query.GetEntityOneById;
internal class GetEntityOneByIdQueryValidator : AbstractValidator<GetEntityOneByIdQuery>
{
    public GetEntityOneByIdQueryValidator()
    {
        RuleFor(q => q.Id)
            .NotEmpty()
            .GreaterThanOrEqualTo(3);
    }
}
