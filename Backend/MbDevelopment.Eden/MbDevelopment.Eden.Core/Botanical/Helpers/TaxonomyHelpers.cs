namespace MbDevelopment.Eden.Core.Botanical.Helpers;

public static class TaxonomyHelpers
{
    public static string ToScientificName(string genus, string species, string? cultivar = null)
    {
        return $"{genus} {species}" + (string.IsNullOrEmpty(cultivar) ? "" : $" '{cultivar}'");
    }
}