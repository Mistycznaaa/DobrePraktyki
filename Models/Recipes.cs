namespace HormoneHarmony.Models;

public class Recipe
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public int PreparationTime { get; set; }
    public int Calories { get; set; }
    public string? Ingredients { get; set; }
    public string? Instructions { get; set; }
    public string? WhyItHelps { get; set; }
    public string? Category { get; set; }
}