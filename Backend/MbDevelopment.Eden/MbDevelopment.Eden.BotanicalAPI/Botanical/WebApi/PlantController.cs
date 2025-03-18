using MbDevelopment.Eden.BotanicalAPI.Shared.Base;
using MbDevelopment.Eden.Contracts.Botanical.CQRS.Commands;
using MbDevelopment.Eden.Contracts.Botanical.CQRS.Queries;
using MbDevelopment.Eden.Contracts.Botanical.Dto;
using MbDevelopment.Eden.Contracts.Botanical.WebApi;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MbDevelopment.Eden.BotanicalAPI.Botanical.WebApi;

[ApiController]
[Route(PlantApi.Route)]
public class PlantController(IMediator mediator, ILogger<ApiControllerBase> logger) : ApiControllerBase(mediator, logger)
{
    [HttpGet("{id:guid}")]
    [ProducesResponseType(typeof(GetPlantDto), StatusCodes.Status200OK)]
    public Task<IActionResult> GetPlantById([FromRoute] Guid id)
    {
        return ExecuteAsync(new GetPlantByIdQuery(id));
    }
    
    
    [HttpPost]
    [AutoValidateAntiforgeryToken]
    [ProducesResponseType(typeof(GetPlantDto), StatusCodes.Status201Created)]
    public Task<IActionResult> CreatePlant([FromBody] CreatePlantCommand request)
    {
       return ExecutePost(request); 
    }
}