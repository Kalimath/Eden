namespace MbDevelopment.Eden.Core.Botanical;

public class TaxonomyData
{
    public string Genus { get; set; }
    public string Species { get; set; }
    public string? Cultivar { get; set; }
    public string[] CommonNames { get; set; }
    
    public string ScientificName => $"{Genus} {Species}" + (string.IsNullOrEmpty(Cultivar) ? "" : $" '{Cultivar}'");
    // Description
}