using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ST10249843_PROG6221_POE
{
    //class for adding ingredients
    public partial class AddIngredientWindow : Window
    {
        private RecipeProperties _newRecipe;
        private List<string> _allIngredients;

        public AddIngredientWindow(RecipeProperties newRecipe)
        {
            InitializeComponent();
            _newRecipe = newRecipe;
            LoadComboBoxData();
        }

        //list in combobox
        private void LoadComboBoxData()
        {
            _allIngredients = GetIngredientNamesFromDatabase();
            IngredientNameComboBox.ItemsSource = _allIngredients.OrderBy(i => i);
            UnitComboBox.ItemsSource = new List<string> { "ml", "mg", "g", "kg", "cup(s)", "tsp", "tbs", "" }; // Allow empty value
            FoodGroupComboBox.ItemsSource = GetFoodGroupsFromDatabase();
        }

        //List of ingredients
        private List<string> GetIngredientNamesFromDatabase()
        {
            return new List<string> { "Flour", "Sugar", "Eggs", "Butter", "Salt", "Pepper", "Olive Oil", "Milk", "Honey" };
        }

        //List of food groups
        private List<string> GetFoodGroupsFromDatabase()
        {
            return new List<string> { "1. Starchy Foods", "2. Vegetables and Fruits", "3. Dry Beans, Peas, Lentils and Soya", "4. Chicken, Fish, Meat and Eggs", "5. Milk and Dairy Products", "6. Fats and Oils", "7. Water" };
            /*
             * 
             * Source: Sweet Life
             * Title: What are the different food groups? A simple explanation
             * URL: https://sweetlife.org.za/what-are-the-different-food-groups-a-simple-explanation/
             */
        }

        private void IngredientNameComboBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            var tb = (TextBox)comboBox.Template.FindName("PART_EditableTextBox", comboBox);
            var filter = tb.Text;

            var filteredList = _allIngredients
                .Where(i => i.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            comboBox.ItemsSource = filteredList;
            comboBox.IsDropDownOpen = true;
            tb.SelectionStart = filter.Length;
            tb.SelectionLength = 0;
            /*
             * Author: Troelsen, A. and Japikse, P.
             * Availability: Apress book: "Pro C# 10 with .NET 6"
             * Date accessed: 26/06/2024
             */

        }

        //code for adding an ingredient
        private void AddIngredientButton_Click(object sender, RoutedEventArgs e)

        {
            string ingredientName = IngredientNameComboBox.Text;
            if (string.IsNullOrEmpty(ingredientName))
            {
                MessageBox.Show("Please select or enter an ingredient name.");
                return;
            }

            //data validation
            if (!double.TryParse(QuantityTextBox.Text, out double quantity))
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            string unit = UnitComboBox.Text;

            if (!double.TryParse(CaloriesTextBox.Text, out double calories))
            {
                MessageBox.Show("Please enter a valid number of calories.");
                return;
            }

            string foodGroup = FoodGroupComboBox.Text;
            if (string.IsNullOrEmpty(foodGroup))
            {
                MessageBox.Show("Please select a food group.");
                return;
            }

            //adds to dictionaries
            _newRecipe.Ingredients[ingredientName] = quantity;
            _newRecipe.OriginalQuantities[ingredientName] = quantity;
            _newRecipe.Units[ingredientName] = unit;
            _newRecipe.Calories[ingredientName] = calories;
            _newRecipe.FoodGroups[ingredientName] = foodGroup;
            /*
            * Author: Troelsen, A. and Japikse, P.
            * Availability: Apress book: "Pro C# 10 with .NET 6"
            * Date accessed: 26/06/2024
            */


            //closes window when ingredient is added
            this.Close();
        }
    }
}
