using Ardalis.GuardClauses;
using JohnChum.SharedKernel.Domain.Exceptions;

namespace JohnChum.SharedKernel.Domain.Common.Specs;

public static class PropertyGuard
{
    public static T Null<T>(
        this IGuardClause guardClause,
        T? property,
        string propertyName,
        string message,
        object? target = null
    ) =>
        property
        ?? throw new NullException(
            new NullExceptionParameters(propertyName, message, NullType.PropertyOrField, target)
        );
}
