using Tools.Results;

namespace Tools.Cqs;

public interface IQueryDefinition<TResult>
{
}

public interface IQueryHandler<TQuery, TResult>
    where TQuery : IQueryDefinition<TResult>
{
    Result<TResult> Handle(TQuery query);
}

public interface ICommandDefinition
{
}

public interface ICommandHandler<TCommand>
    where TCommand : ICommandDefinition
{
    Result Handle(TCommand command);
}

public interface ICommandDefinition<TResult>
{
}

public interface ICommandHandler<TCommand, TResult>
    where TCommand : ICommandDefinition<TResult>
{
    Result<TResult> Handle(TCommand query);
}