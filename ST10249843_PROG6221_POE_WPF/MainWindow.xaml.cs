using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ST10249843_PROG6221_POE
{
    //class for the main window menu
    public partial class MainWindow : Window
    {
        private RecipeMethods recipeMethods = new RecipeMethods();

        public MainWindow()
        {
            InitializeComponent();
            recipeMethods.RecipeAdded += RecipeMethods_RecipeAdded;
        }

        //calls each of the wpfs
        private void EnterRecipe_Click(object sender, RoutedEventArgs e)
        {
            var enterRecipeWindow = new EnterRecipeWindow(recipeMethods);
            enterRecipeWindow.Show();
        }

        private void DisplayRecipes_Click(object sender, RoutedEventArgs e)
        {
            var displayWindow = new DisplayWindow(recipeMethods);
            displayWindow.Show();
        }

        private void DisplayRecipes()
        {
            List<RecipeProperties> recipes = recipeMethods.GetRecipes();
            RecipeListBox.ItemsSource = recipes;
        }

        private void ScaleRecipe_Click(object sender, RoutedEventArgs e)
        {
            var scaleRecipeWindow = new ScaleRecipeWindow(recipeMethods);
            scaleRecipeWindow.Show();
        }

        private void ResetQuantities_Click(object sender, RoutedEventArgs e)
        {
            var resetQuantitiesWindow = new ResetQuantitiesWindow(recipeMethods);
            resetQuantitiesWindow.Show();
        }

        private void ClearRecipeBook_Click(object sender, RoutedEventArgs e)
        {
            //ask for confirmation before clearing the recipe book
            var result = MessageBox.Show("Are you sure you want to clear the recipe book?", "Confirm Clear", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                recipeMethods.ClearRecipeBook();
                RecipeListBox.ItemsSource = null;
            }
            /*
             * Author: Troelsen, A. and Japikse, P.
             * Availability: Apress book: "Pro C# 10 with .NET 6"
             * Date accessed: 26/06/2024
             */

        }

        private void FilterRecipes_Click(object sender, RoutedEventArgs e)
        {
            var filterRecipesWindow = new FilterRecipesWindow(recipeMethods);
            filterRecipesWindow.Show();
        }

        private void RecipeMethods_RecipeAdded(string recipeName)
        {
            RecipeListBox.ItemsSource = recipeMethods.GetRecipes();
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
