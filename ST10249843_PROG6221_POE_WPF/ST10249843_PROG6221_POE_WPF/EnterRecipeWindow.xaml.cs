using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ST10249843_PROG6221_POE
{
    //window to enter a recipe
    public partial class EnterRecipeWindow : Window
    {
        private RecipeMethods recipeMethods;
        private RecipeProperties newRecipe;

        public EnterRecipeWindow(RecipeMethods methods)
        {
            InitializeComponent();
            recipeMethods = methods;
            newRecipe = new RecipeProperties();
        }

        //button to add an ingredient
        private void AddIngredient_Click(object sender, RoutedEventArgs e)
        {
            var addIngredientWindow = new AddIngredientWindow(newRecipe);
            addIngredientWindow.ShowDialog();
            UpdateIngredientsPanel();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //method to add a step to the recipe
        private void AddStep_Click(object sender, RoutedEventArgs e)
        {
            if (StepTextBox != null && !string.IsNullOrWhiteSpace(StepTextBox.Text))
            {
                ListBoxItem item = new ListBoxItem();
                item.Content = $"Step {StepsPanel.Items.Count + 1}: {StepTextBox.Text}";

                StepsPanel.Items.Add(item);

                StepTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Please enter a step before adding.");
            }
            /*
             * Author: Troelsen, A. and Japikse, P.
             * Availability: Apress book: "Pro C# 10 with .NET 6"
             * Date accessed: 26/06/2024
             */

        }

        //method to save a recipe and go back to main window
        private void SaveRecipe_Click(object sender, RoutedEventArgs e)
        {
            newRecipe.RecipeName = RecipeNameTextBox.Text;

            foreach (ListBoxItem listBoxItem in StepsPanel.Items)
            {
                if (listBoxItem.Content is string stepText)
                {
                    newRecipe.Steps.Add(stepText);
                }
            }

            recipeMethods.EnterRecipe(newRecipe);
            this.Close();
        }

        private void UpdateIngredientsPanel()
        {
            IngredientsPanel.Items.Clear();

            foreach (var ingredient in newRecipe.Ingredients)
            {
                ListBoxItem item = new ListBoxItem();
                item.Content = $"{ingredient.Key}: {ingredient.Value} {newRecipe.Units[ingredient.Key]}";
                IngredientsPanel.Items.Add(item);
            }
        }
    }
}
