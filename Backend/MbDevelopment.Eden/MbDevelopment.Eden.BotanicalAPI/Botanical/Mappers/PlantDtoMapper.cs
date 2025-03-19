using MbDevelopment.Eden.Contracts.Botanical.CQRS.Commands;
using MbDevelopment.Eden.Contracts.Botanical.Dto;
using MbDevelopment.Eden.Core.Botanical;

namespace MbDevelopment.Eden.BotanicalAPI.Botanical.Mappers;

public static class PlantDtoMapper {
    public static PlantDto ToPlantDto(this Plant plant)
    {
        return new PlantDto
        {
            Id = plant.Id,
            Taxonomy = plant.PlantTaxonomy.ToPlantTaxonomyDto()
        };
    }

    public static Plant ToPlant(this CreatePlantCommand command)
    {
        return new Plant
        {
            Id = Guid.Empty,
            PlantTaxonomy = new PlantTaxonomy
            {
                CommonNames = command.CommonNames,
                Genus = command.Genus,
                Species = command.Species,
                Cultivar = command.Cultivar,
                Description = command.Description
            }
        };
    }
}