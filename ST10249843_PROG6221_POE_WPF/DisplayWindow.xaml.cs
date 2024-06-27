using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ST10249843_PROG6221_POE
{
    //class for displaying window
    public partial class DisplayWindow : Window
    {
        private RecipeMethods _recipeMethods;

        public DisplayWindow(RecipeMethods recipeMethods)
        {
            InitializeComponent();
            _recipeMethods = recipeMethods;
            LoadRecipes();
        }

        //back button
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Close the current window
        }

        private void LoadRecipes()
        {
            var recipes = _recipeMethods.GetRecipes().OrderBy(r => r.RecipeName).ToList();
            RecipeListBox.ItemsSource = recipes;
            RecipeListBox.DisplayMemberPath = "RecipeName";
        }

        //Displaying the recipes
        private void RecipeListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RecipeListBox.SelectedItem is RecipeProperties selectedRecipe)
            {
                RecipeNameTextBlock.Text = selectedRecipe.RecipeName;

                // prepare ingredients with checkbox state
                var ingredientsList = selectedRecipe.Ingredients.Select(ingredient =>
                    new IngredientInfo
                    {
                        IsChecked = false,
                        DisplayText = $"{selectedRecipe.OriginalQuantities[ingredient.Key]} {selectedRecipe.Units[ingredient.Key]} of {ingredient.Key} ({selectedRecipe.Calories[ingredient.Key]} calories, {selectedRecipe.FoodGroups[ingredient.Key]})"
                    }).ToList();
                IngredientsListBox.ItemsSource = ingredientsList;

                // prepare steps with checkbox state
                var stepsList = selectedRecipe.Steps.Select(step =>
                    new IngredientInfo
                    {
                        IsChecked = false,
                        DisplayText = step
                    }).ToList();
                StepsListBox.ItemsSource = stepsList;

                // display total calories
                TotalCaloriesTextBlock.Text = $"Total Calories: {selectedRecipe.TotalCalories}";

                // display warning if total calories exceed 300
                WarningTextBlock.Text = selectedRecipe.TotalCalories > 300 ? "Warning: Calories exceed 300 calories!" : string.Empty;

                /*
                 * Author: Troelsen, A. and Japikse, P.
                 * Availability: Apress book: "Pro C# 10 with .NET 6"
                 * Date accessed: 26/06/2024
                 */

            }
        }
    }
}
public class IngredientInfo
{
    public bool IsChecked { get; set; }
    public string DisplayText { get; set; }
}