using MbDevelopment.Eden.Contracts.Botanical.Dto;
using MbDevelopment.Eden.Core.Botanical;

namespace MbDevelopment.Eden.BotanicalAPI.Botanical.Mappers;

public static class PlantTaxonomyDtoMapper
{
    public static PlantTaxonomy ToPlantTaxonomy(this PlantTaxonomyDto plantTaxonomyDto)
    {
        return new PlantTaxonomy
        {
            CommonNames = plantTaxonomyDto.CommonNames,
            Genus = plantTaxonomyDto.Genus,
            Species = plantTaxonomyDto.Species,
            Cultivar = plantTaxonomyDto.Cultivar,
            Description = plantTaxonomyDto.Description
        };
    }

    public static PlantTaxonomyDto ToPlantTaxonomyDto(this PlantTaxonomy plantTaxonomyDto)
    {
        return new PlantTaxonomyDto
        {
            CommonNames = plantTaxonomyDto.CommonNames,
            Genus = plantTaxonomyDto.Genus,
            Species = plantTaxonomyDto.Species,
            Cultivar = plantTaxonomyDto.Cultivar,
            Description = plantTaxonomyDto.Description
        };
    }  
}