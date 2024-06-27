using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ST10249843_PROG6221_POE
{
    //class for filtering recipes wpf
    public partial class FilterRecipesWindow : Window
    {
        private RecipeMethods _recipeMethods;
        private ObservableCollection<string> FilteredRecipes;

        public FilterRecipesWindow(RecipeMethods recipeMethods)
        {
            InitializeComponent();
            FilteredRecipes = new ObservableCollection<string>();
            FilteredRecipesList.ItemsSource = FilteredRecipes;
            _recipeMethods = recipeMethods;
        }

        //back button
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //clear button
        private void ClearFilterButton_Click(object sender, RoutedEventArgs e)
        {
            FilterTypeComboBox.SelectedIndex = -1;
            FilterValueTextBox.Clear();
            FilteredRecipes.Clear();
        }

        //apply the filter button
        private void ApplyFilterButton_Click(object sender, RoutedEventArgs e)
        {
            var selectedFilter = (FilterTypeComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            var filterValue = FilterValueTextBox.Text.Trim();
            var filteredRecipes = _recipeMethods.GetRecipes();

            if (string.IsNullOrWhiteSpace(selectedFilter) || string.IsNullOrWhiteSpace(filterValue))
            {
                MessageBox.Show("Please select a filter type and enter a value.");
                return;
            }

            switch (selectedFilter)
            {
                case "Ingredient":
                    filteredRecipes = filteredRecipes.Where(r => r.Ingredients.Keys.Any(key => key.ToLower().Contains(filterValue.ToLower()))).ToList();
                    /*
                     * Author: Troelsen, A. and Japikse, P.
                     * Availability: Apress book: "Pro C# 10 with .NET 6"
                     * Date accessed: 26/06/2024
                     */

                    break;

                case "Food Group":
                    filteredRecipes = filteredRecipes.Where(r => r.FoodGroups.Values.Any(group => group.ToLower().Contains(filterValue.ToLower()))).ToList();
                    break;

                case "Maximum Calories":
                    if (double.TryParse(filterValue, out double maxCalories))
                    {
                        filteredRecipes = filteredRecipes.Where(r => r.TotalCalories <= maxCalories).ToList();
                    }
                    else
                    {
                        //data validation
                        MessageBox.Show("Please enter a valid number for maximum calories.");
                        return;
                    }
                    break;

                default:
                    MessageBox.Show("Invalid filter type selected.");
                    return;
            }

            if (filteredRecipes.Any())
            {
                FilteredRecipes.Clear();
                foreach (var recipe in filteredRecipes)
                {
                    FilteredRecipes.Add(recipe.RecipeName);
                }
            }
            else
            {
                MessageBox.Show("No recipes found matching the filter criteria.");
                FilteredRecipes.Clear();
            }
        }
    }
}
