using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace ST10249843_PROG6221_POE
{
    //class for scaling values in recipe
    public partial class ScaleRecipeWindow : Window
    {
        public event EventHandler<RecipeChangedEventArgs> RecipeChanged;

        private RecipeMethods _recipeMethods;

        public ScaleRecipeWindow(RecipeMethods recipeMethods)
        {
            InitializeComponent();
            _recipeMethods = recipeMethods;
            LoadRecipes();
        }

        private void LoadRecipes()
        {
            var recipes = _recipeMethods.GetRecipes().Select(r => r.RecipeName).ToList();
            RecipeComboBox.ItemsSource = recipes;
        }

        //scale button selections
        private void ScaleRecipeButton_Click(object sender, RoutedEventArgs e)
        {
            if (RecipeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a recipe.");
                return;
            }

            if (ScaleFactorComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a scale factor.");
                return;
            }

            //ask for confirmation before scaling
            var result = MessageBox.Show("Are you sure you want to scale this recipe?", "Confirm Scaling", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                ScaleRecipe();
            }

            /*
             * Author: Troelsen, A. and Japikse, P.
             * Availability: Apress book: "Pro C# 10 with .NET 6"
             * Date accessed: 26/06/2024
             */

        }

        //scale ingredients
        private void ScaleRecipe()
        {
            string selectedRecipeName = RecipeComboBox.SelectedItem.ToString();
            var recipe = _recipeMethods.GetRecipes().FirstOrDefault(r => r.RecipeName == selectedRecipeName);

            if (recipe != null)
            {
                var selectedComboBoxItem = ScaleFactorComboBox.SelectedItem as ComboBoxItem;
                if (selectedComboBoxItem != null && double.TryParse(selectedComboBoxItem.Tag.ToString(), out double scaleFactor))
                {
                    //scale the ingredients
                    var scaledIngredients = recipe.Ingredients.ToDictionary(
                        ingredient => ingredient.Key,
                        ingredient => recipe.OriginalQuantities[ingredient.Key] * scaleFactor
                    );

                    //construct the full recipe details including original and scaled ingredients
                    StringBuilder fullRecipeBuilder = new StringBuilder();
                    fullRecipeBuilder.AppendLine($"Recipe: {recipe.RecipeName}");
                    fullRecipeBuilder.AppendLine();

                    fullRecipeBuilder.AppendLine("Ingredients:");
                    foreach (var ingredient in scaledIngredients)
                    {
                        var quantity = ingredient.Value;
                        var unit = recipe.Units[ingredient.Key];
                        var ingredientName = ingredient.Key;
                        var calories = recipe.Calories[ingredient.Key];
                        var foodGroup = recipe.FoodGroups[ingredient.Key];

                        fullRecipeBuilder.AppendLine($"{quantity} {unit} of {ingredientName} ({calories} cal, {foodGroup})");
                    }

                    fullRecipeBuilder.AppendLine();
                    fullRecipeBuilder.AppendLine("Steps:");
                    foreach (var step in recipe.Steps)
                    {
                        fullRecipeBuilder.AppendLine(step);
                    }

                    //display the full recipe details in FullRecipeTextBox
                    FullRecipeTextBox.Text = fullRecipeBuilder.ToString();

                    //notify other windows or components about the recipe change
                    OnRecipeChanged(new RecipeChangedEventArgs(recipe));
                }
                else
                {
                    MessageBox.Show("Please select a valid scale factor.");
                }
            }
            else
            {
                MessageBox.Show("Selected recipe not found.");
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        protected virtual void OnRecipeChanged(RecipeChangedEventArgs e)
        {
            RecipeChanged?.Invoke(this, e);
        }
    }

    public class RecipeChangedEventArgs : EventArgs
    {
        public RecipeProperties ChangedRecipe { get; }

        public RecipeChangedEventArgs(RecipeProperties recipe)
        {
            ChangedRecipe = recipe;
        }
    }
}
