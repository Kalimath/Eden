using MbDevelopment.Eden.Contracts.Botanical.Dto;
using MbDevelopment.Eden.Contracts.Shared.CQRS.Base;

namespace MbDevelopment.Eden.Contracts.Botanical.CQRS.Queries;

public class GetPlantByIdQuery(Guid id) : QueryBase<GetPlantDto>;