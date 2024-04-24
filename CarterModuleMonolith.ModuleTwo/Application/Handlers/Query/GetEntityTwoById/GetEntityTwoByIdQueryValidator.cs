using FluentValidation;

namespace CarterModuleMonolith.ModuleTwo.Application.Handlers.Query.GetEntityOneById;
internal class GetEntityTwoByIdQueryValidator : AbstractValidator<GetEntityTwoByIdQuery>
{
    public GetEntityTwoByIdQueryValidator()
    {
        RuleFor(q => q.Id)
            .NotEmpty()
            .GreaterThanOrEqualTo(3);
    }
}
