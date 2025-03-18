namespace MbDevelopment.Eden.Core.Botanical;

public class PlantTaxonomy
{
    public string Genus { get; set; }
    public string Species { get; set; }
    public string? Cultivar { get; set; }
    public string[] CommonNames { get; set; } = [];
    public string Description { get; set; } = string.Empty;
    public Guid PlantId { get; set; }
    
    public string ScientificName => $"{Genus} {Species}" + (string.IsNullOrEmpty(Cultivar) ? "" : $" '{Cultivar}'");
}