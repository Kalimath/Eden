using MbDevelopment.Eden.BotanicalAPI.Botanical.Mappers;
using MbDevelopment.Eden.Contracts.Botanical.CQRS.Commands;
using MbDevelopment.Eden.Contracts.Botanical.Dto;
using MbDevelopment.Eden.Core.Botanical;
using MbDevelopment.Eden.DataAccess.Base;
using MediatR;


namespace MbDevelopment.Eden.BotanicalAPI.Botanical.CQRS.Commands;

public class CreatePlantCommandHandler : IRequestHandler<CreatePlantCommand, PlantDto>
{
    private readonly IRepository<Plant> _plantRepo;

    public CreatePlantCommandHandler(IRepository<Plant> plantRepo)
    {
        _plantRepo = plantRepo;
    }
    
    public async Task<PlantDto> Handle(CreatePlantCommand request, CancellationToken cancellationToken)
    {
        var requestScientificName = ToScientificName(request.Species, request.Genus, request.Cultivar);
        var plantExistsWithName = await _plantRepo.Exists(x => x.PlantTaxonomy.ScientificName == requestScientificName, cancellationToken);
        if (plantExistsWithName)
        {
            throw new InvalidOperationException("Plant with the same scientific name already exists.");
        }

        var newPlant = new Plant
        {
            PlantTaxonomy = new PlantTaxonomy
            {
                CommonNames = request.CommonNames,
                Genus = request.Genus,
                Species = request.Species,
                Cultivar = request.Cultivar,
                Description = request.Description
            }
        };
        
        _plantRepo.Add(newPlant);
        await _plantRepo.SaveChangesAsync(cancellationToken);
        var createdPlant = await _plantRepo.GetAsync(x => x.PlantTaxonomy.ScientificName == requestScientificName, cancellationToken);
        if (createdPlant is null) 
        {
            throw new Exception("Failed to retrieve created plant.");
        }
        
        return createdPlant.ToPlantDto();
    }
}