namespace MbDevelopment.Eden.Contracts.Botanical.Dto;

public record PlantTaxonomyDto
{
    public string Genus { get; init; }
    public string Species { get; init; }
    public string? Cultivar { get; init; }
    public string[] CommonNames { get; init; } = [];
    public string Description { get; init; } = string.Empty;
}