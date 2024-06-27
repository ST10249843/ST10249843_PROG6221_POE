using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10249843_PROG6221_POE
{
    public class RecipeMethods
    {
        //event handler
        public delegate void RecipeAddedHandler(string recipeName);
        public event RecipeAddedHandler RecipeAdded;

        //list of properties
        private List<RecipeProperties> RecipeBook = new List<RecipeProperties>();

        public void EnterRecipe(RecipeProperties newRecipe)
        {
            RecipeBook.Add(newRecipe);
            RecipeAdded?.Invoke(newRecipe.RecipeName);
        }

        public List<RecipeProperties> GetRecipes()
        {
            return RecipeBook.OrderBy(r => r.RecipeName).ToList();
        }

        //scales the recipe
        public void ScaleRecipe(string recipeName, double scaleFactor)
        {
            var recipe = RecipeBook.FirstOrDefault(r => r.RecipeName == recipeName);
            if (recipe != null)
            {
                foreach (var ingredient in recipe.Ingredients.Keys.ToList())
                {
                    recipe.Ingredients[ingredient] = recipe.OriginalQuantities[ingredient] * scaleFactor;
                }
            }
        }

        //resets the quatities
        public void ResetQuantities(string recipeName)
        {
            var recipe = RecipeBook.FirstOrDefault(r => r.RecipeName == recipeName);
            if (recipe != null)
            {
                recipe.Ingredients = new Dictionary<string, double>(recipe.OriginalQuantities);
            }
        }

        //clears the recipe book
        public void ClearRecipeBook()
        {
            RecipeBook.Clear();
        }

        public List<RecipeProperties> FilterRecipes(string ingredient = null, string foodGroup = null, double? maxCalories = null)
        {
            return RecipeBook.Where(r =>
                (ingredient == null || r.Ingredients.ContainsKey(ingredient)) &&
                (foodGroup == null || r.FoodGroups.Values.Contains(foodGroup)) &&
                (maxCalories == null || r.Calories.Values.Sum() <= maxCalories)
            ).ToList();
        }
    }
}
