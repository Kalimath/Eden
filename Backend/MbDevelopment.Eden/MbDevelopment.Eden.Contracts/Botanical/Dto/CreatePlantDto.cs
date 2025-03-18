namespace MbDevelopment.Eden.Contracts.Botanical.Dto;

public record CreatePlantDto
{
    public PlantTaxonomyDto PlantTaxonomy { get; init; }
    // characteristics
    // NutrientBalance (NPK, water, soil)
    // Habitat
    // Distribution
    // Symbiosis
    // FoodRequirements
    // dimensions
    // flowerInfo
    // growthInfo
    // images
}