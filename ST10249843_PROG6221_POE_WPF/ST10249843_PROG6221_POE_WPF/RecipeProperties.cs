using System;
using System.Collections.Generic;
using System.Linq;

public class RecipeProperties
{
    //properties
    public string RecipeName { get; set; }
    public Dictionary<string, double> Ingredients { get; set; } = new Dictionary<string, double>();
    public Dictionary<string, double> OriginalQuantities { get; set; } = new Dictionary<string, double>();
    public Dictionary<string, string> Units { get; set; } = new Dictionary<string, string>();
    public Dictionary<string, double> Calories { get; set; } = new Dictionary<string, double>();
    public Dictionary<string, string> FoodGroups { get; set; } = new Dictionary<string, string>();
    public List<string> Steps { get; set; } = new List<string>();

    /*
     * Author: Mahesh Chand
     * Availability: https://www.c-sharpcorner.com/UploadFile/mahesh/dictionary-in-C-Sharp/
     * Date created: 25/08/2023
     */
    /*
     * Source: GeeksforGeeks
     * Title: C# Dictionary with Examples
     * URL: https://www.geeksforgeeks.org/c-sharp-dictionary-with-examples/
     */

    public string FoodGroup { get; set; }

    //calculates the total calories
    public double TotalCalories
    {
        get
        {
            return Ingredients.Sum(ingredient => Calories.ContainsKey(ingredient.Key) ? Calories[ingredient.Key] : 0);
        }
    }

}
