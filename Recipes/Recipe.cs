using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook.Recipes;

public class Recipe
{
    public IEnumerable<Ingredient> Ingredients { get; }

    public Recipe(IEnumerable<Ingredient> ingredients)
    {
        Ingredients = ingredients;
    }

    public override string ToString()
    {
        var ingredientStringsList = Ingredients.Select(ing => $"{ing.Name}. {ing.PreparationInstructions}");
        return string.Join(Environment.NewLine, ingredientStringsList);
    }

}