using MediatR;

namespace MbDevelopment.Eden.Contracts.Shared.CQRS.Base;

public abstract class QueryBase<T> : IRequest<T> where T : class
{
}