using FluentValidation;
using MbDevelopment.Eden.Contracts.Botanical.CQRS.Commands;

namespace MbDevelopment.Eden.BotanicalAPI.Botanical.Validation.Plant;

public class CreatePlantCommandValidator : AbstractValidator<CreatePlantCommand>
{
    public CreatePlantCommandValidator()
    {
        RuleFor(x => x).NotNull();
        RuleFor(x => x.Species).NotEmpty();
        RuleFor(x => x.Genus).NotEmpty();
        RuleFor(x => x.Description);
    }
}