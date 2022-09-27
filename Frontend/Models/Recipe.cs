using System;
namespace Frontend.Models;

public class Recipe
{
    public Guid Id { get; set; } = new();
    public string Name { get; set; } = string.Empty;
    public List<string> Ingredients { get; set; } = new();
    public List<string> Instructions { get; set; } = new();
    public List<Guid> CategoriesIds { get; set; } = new();
}

