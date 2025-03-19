namespace MbDevelopment.Eden.Core.Botanical.Helpers;

public static class ObjectHelpers
{
    public static bool NotNull(this object? obj)
    {
        return obj is not null;
    }
}