namespace Receptor.Data.Models;

public class Recipe
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public required List<string> Ingredients { get; set; }
    public required string Instructions { get; set; }
    public string? Serving { get; set; }
}