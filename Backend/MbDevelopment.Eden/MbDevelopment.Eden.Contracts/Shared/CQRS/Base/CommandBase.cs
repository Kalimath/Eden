using MediatR;

namespace MbDevelopment.Eden.Contracts.Shared.CQRS.Base;

public abstract class CommandBase<T> : IRequest<T> where T : class{}