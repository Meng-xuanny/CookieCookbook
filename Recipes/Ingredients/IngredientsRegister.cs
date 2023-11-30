namespace CookieCookbook.Recipes.Ingredients;

public class IngredientsRegister : IIngredientsRegister
{
    public IEnumerable<Ingredient> All { get; } = new List<Ingredient>
    {
        new WheatFlour(),
        new SpeltFlour(),
        new Butter(),
        new Chocolate(),
        new Sugar(),
        new Cardamom(),
        new Cinnamon(),
        new CocoaPowder()
    };

    public Ingredient GetById(int id)
    {
        var allIngredientsWithGivenIds = All.Where(ingredient => ingredient.Id == id);

        if(allIngredientsWithGivenIds.Count() > 1)
        {
            throw new InvalidOperationException($"More than one ingredient have ID equal to {id}.");
        }

       return allIngredientsWithGivenIds.FirstOrDefault();
       
    }
}

