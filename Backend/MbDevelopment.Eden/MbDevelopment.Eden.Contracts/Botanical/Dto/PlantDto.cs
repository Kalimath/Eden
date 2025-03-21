namespace MbDevelopment.Eden.Contracts.Botanical.Dto;

public record PlantDto
{
    public Guid Id { get; init; }
    public PlantTaxonomyDto Taxonomy { get; init; }
    // characteristics
    // NutrientBalance (NPK, water, soil)
    // Habitat
    // ...
}