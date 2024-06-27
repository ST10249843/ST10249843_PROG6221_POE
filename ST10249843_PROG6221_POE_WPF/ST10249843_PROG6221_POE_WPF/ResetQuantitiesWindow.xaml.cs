using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace ST10249843_PROG6221_POE
{
    //class to reset quantities
    public partial class ResetQuantitiesWindow : Window
    {
        private RecipeMethods _recipeMethods;

        public ResetQuantitiesWindow(RecipeMethods recipeMethods)
        {
            InitializeComponent();
            _recipeMethods = recipeMethods;
            LoadRecipes();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //displays the list of recipes
        private void LoadRecipes()
        {
            var recipes = _recipeMethods.GetRecipes().Select(r => r.RecipeName).ToList();
            RecipeComboBox.ItemsSource = recipes;
        }

        //resert and display quantities
        private void ResetQuantitiesButton_Click(object sender, RoutedEventArgs e)
        {
            if (RecipeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a recipe.");
                return;
            }

            /*
             * Author: Troelsen, A. and Japikse, P.
             * Availability: Apress book: "Pro C# 10 with .NET 6"
             * Date accessed: 26/06/2024
             */

            string selectedRecipeName = RecipeComboBox.SelectedItem.ToString();
            var recipe = _recipeMethods.GetRecipes().FirstOrDefault(r => r.RecipeName == selectedRecipeName);

            if (recipe != null)
            {
                // ask for confirmation before resetting
                var result = MessageBox.Show("Are you sure you want to reset the quantities for this recipe?", "Confirm Reset", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (result == MessageBoxResult.Yes)
                {
                    //reset the ingredients to their original quantities
                    recipe.Ingredients = new Dictionary<string, double>(recipe.OriginalQuantities);

                    //construct the full recipe details including reset ingredients
                    StringBuilder fullRecipeBuilder = new StringBuilder();
                    fullRecipeBuilder.AppendLine($"Recipe: {recipe.RecipeName}");
                    fullRecipeBuilder.AppendLine();
                    fullRecipeBuilder.AppendLine("Ingredients:");
                    foreach (var ingredient in recipe.Ingredients)
                    {
                        var quantity = ingredient.Value;
                        var unit = recipe.Units[ingredient.Key];
                        var ingredientName = ingredient.Key;
                        var calories = recipe.Calories[ingredient.Key];
                        var foodGroup = recipe.FoodGroups[ingredient.Key];

                        fullRecipeBuilder.AppendLine($"{quantity} {unit}(s) of {ingredientName} ({calories} cal, {foodGroup})");
                    }

                    fullRecipeBuilder.AppendLine();
                    fullRecipeBuilder.AppendLine("Steps:");
                    foreach (var step in recipe.Steps)
                    {
                        fullRecipeBuilder.AppendLine(step);
                    }

                    //display the full recipe details in ResetIngredientsList
                    ResetIngredientsList.ItemsSource = new List<string> { fullRecipeBuilder.ToString() };
                }
            }
            else
            {
                MessageBox.Show("Selected recipe not found.");
            }
        }
    }
}
