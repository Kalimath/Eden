using MbDevelopment.Eden.Contracts.Botanical.Dto;
using MbDevelopment.Eden.Contracts.Shared.CQRS.Base;

namespace MbDevelopment.Eden.Contracts.Botanical.CQRS.Commands;

public class CreatePlantCommand : CommandBase<CreatePlantDto>
{
    public required string Genus { get; init; }
    public required string Species { get; init; }
    public string? Cultivar { get; init; } = null;
    public string[] CommonNames { get; init; } = [];
    public string Description { get; init; } = string.Empty;
}