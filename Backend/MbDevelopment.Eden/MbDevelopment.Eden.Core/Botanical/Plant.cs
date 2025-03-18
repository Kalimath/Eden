using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MbDevelopment.Eden.Core.Botanical;

namespace MbDevelopment.Eden.Core;

public class Plant : IObjectIdentity
{
    public int Id { get; set; }
    public TaxonomyData Taxonomy { get; set; }
    // characteristics
    // NutrientBalance (NPK, water, soil)
    // Habitat
    // Distribution
    // Symbiosis
    // FoodRequirements
    // dimensions
    // flowerInfo
    // growthInfo
    // images
}

public interface IObjectIdentity
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
    public int Id { get; set; }
}