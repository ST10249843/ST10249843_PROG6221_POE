SANELE’S RECIPE BOOK APPLICATION 
Name: Sajana Bidesi
Student ID: ST10249843

Table of Contents
SANELE’S RECIPE BOOK APPLICATION	0
Table of Contents	0
Introduction	1
Overview	2
System Requirements	3
How to compile and run the application	4
Step 1: Open Visual Studio:	4
Step 1: Open Your Project:	4
Step 1: Set the Startup Project:	4
Step 1: Build the Solution:	4
Step 1: Run the Application:	4
Step 1: Navigate and Test:	4
Step 1: Stop Debugging:	4
Colour Code and Themes	5
UI Design	6
Changes from POE Part 2	10
Conclusion	11
Appendix	12






Introduction
Welcome to Sanele's Recipe Book Application! This document provides comprehensive guidance on using the application efficiently. Whether you're an experienced cook or new to the kitchen, this guide will help you manage your recipes effectively.
Sanele's Recipe Book Application is a user-friendly WPF (Windows Presentation Foundation) application built in C#, designed to help cooks organize their recipes efficiently. This application offers a range of functionalities including entering recipes, displaying detailed recipe information, scaling ingredient quantities, reverting to original quantities, filtering recipes, clearing the recipe book, and exiting the program.

GITHUB LINK:  https://github.com/ST10249843/ST10249843_PROG6221_POE.git 
YOUTUBE LINK: https://youtu.be/-rTWxcwST7Q 















Overview
Enter Recipe: Clicking the "Enter Recipe" button opens the EnterRecipeWindow.xaml where you can input the recipe name, list of ingredients, quantities, units of measurement, steps, and descriptions. Save the recipe or use the back button to return without saving.
Add Ingredient: Clicking the "Add Ingredient" button opens the AddIngredientWindow.xaml where you can enter the ingredient details: name, quantity, unit of measurement, calories, and food group. All fields are mandatory.
Display Recipe: The "Display Recipe" button opens the DisplayWindow.xaml. Select a recipe from an alphabetical list to view its details including ingredients, steps, and total calories. Use the back button to return to the main window.
Scale Recipe: Clicking the "Scale Recipe" button opens the ScaleRecipeWindow.xaml where you can select a recipe and scale its quantities by half, double, or triple. The scaled recipe details are displayed below.
Reset Quantities: Clicking "Reset Quantities" opens the ResetQuantitiesWindow.xaml. Select a recipe from a dropdown to revert its ingredient quantities to their original values.
Filter Recipes: The "Filter Recipes" button opens the FilterRecipesWindow.xaml. Filter recipes by ingredient, food group, or maximum calories using dropdowns and text boxes. Click "Apply Filter" to see matching recipes; use "Clear Filter" to reset.
Clear Recipe Book: Clicking "Clear Recipe Book" prompts a confirmation message. Confirm to clear all recipes from the application.
Exit: The "Exit" button closes the application.









System Requirements
Hardware Requirements:
•	Processor: 1 GHz or faster
•	RAM: 2 GB or more
•	Hard Disk Space: 500 MB free space
•	Display: 1024 x 768 resolution or higher
Software Requirements:
•	Operating System: Windows 7 or later
•	.NET Framework: Version 4.7.2 or later (installed with the application)














How to compile and run the application
Step 1: Open Visual Studio:
•	Launch Visual Studio from your Start menu or desktop shortcut.
Step 1: Open Your Project:
•	Open the solution (.sln) file:
o	Double-click the .sln file in File Explorer or use Visual Studio's File > Open > Project/Solution menu.
Step 1: Set the Startup Project:
•	In Solution Explorer, right-click your project.
•	Select Set as StartUp Project.
Step 1: Build the Solution:
•	Compile all code and resources:
o	Press Ctrl + Shift + B or go to Build > Build Solution.
o	Check Output window (View > Output) for errors; fix any before continuing.
Step 1: Run the Application:
•	Start debugging:
o	Press F5 for debugging mode (with breakpoints).
o	Press Ctrl + F5 for normal mode (without breakpoints).
Step 1: Navigate and Test:
•	Visual Studio launches your application (e.g., Windows Forms, WPF).
•	Test functionality as intended.
Step 1: Stop Debugging:
•	To close the application:
o	Press Shift + F5 or click Stop Debugging in the toolbar.


Colour Code and Themes
Sanele's Recipe Book Application uses a carefully selected warm, monochromatic palette of browns to create a cozy and inviting user interface. This thoughtful choice of colours not only enhances the visual appeal of the application but also contributes to a comfortable and pleasant user experience. The warm tones evoke feelings of warmth and homeliness, reminiscent of freshly baked cookies and the joy of cooking.
Colour Palette:
Primary Colour (#3e2723): This deep, rich brown serves as the main colour throughout the application. It provides a strong, stable background that is both elegant and understated, ensuring that the interface remains easy on the eyes during prolonged use.
Secondary Colours: Various shades of lighter and darker browns are used to highlight different UI elements, creating a harmonious and balanced look. These secondary colours help to differentiate between interactive components such as buttons, text fields, and panels, making navigation intuitive and straightforward.
Accent Colours: Subtle accents in complementary colours are used sparingly to draw attention to important information and actions, such as warnings, notifications, and active selections. These accents provide visual cues that guide the user through the application without overwhelming the primary aesthetic.







UI Design
•	MainWindow.xaml: Main interface for navigating functionalities. 









•	EnterRecipeWindow.xaml: Enter new recipes with ingredients and steps.

•	DisplayWindow.xaml: Display detailed recipe information and cooking progress.


•	ScaleRecipeWindow.xaml: Scale recipe quantities.







•	ResetRecipeWindow.xaml: Reset recipes to original quantities.


•	FilterRecipeWindow.xaml: Filter recipes by various criteria. 

•	Clear Recipe Book: Clear all saved recipes.

•	Exit Application: Closes the application.
 


Changes from POE Part 2
•	Implemented error handling for user inputs with more specific error messages.
•	Consolidated duplicate error-handling prompts into helper methods for improved code readability.
•	Ensured consistent formatting in console output messages.
•	Added confirmation prompts for ScaleIngredients, ResetQuantities, and clearing all recipes to prevent accidental data loss.
•	Initialized all dictionaries (Ingredients, Units, OriginalQuantities, Calories, FoodGroups) properly in the constructor to avoid null reference exceptions.


















Conclusion
Sanele's Recipe Book Application offers a comprehensive and user-friendly solution for managing your culinary creations. This WPF application, built in C#, is designed to meet the needs of both novice and experienced cooks by providing an intuitive interface and a wide range of functionalities. From entering and scaling recipes to filtering and displaying detailed information, this application makes it easy to organize and manage your recipe collection efficiently.
By leveraging a warm, monochromatic color palette and thoughtful UI design, the application creates a cozy and inviting user experience that enhances your time in the kitchen. The attention to detail in error handling, user prompts, and overall design ensures that you can focus on your cooking without being bogged down by technical issues.
Whether you're looking to scale your favorite recipe for a large gathering, filter recipes to meet specific dietary requirements, or simply keep track of your culinary experiments, Sanele's Recipe Book Application is the perfect companion. It helps you streamline your cooking process, making it more enjoyable and efficient.
We hope this application brings joy and convenience to your cooking adventures. Thank you for choosing Sanele's Recipe Book Application, and happy cooking!













Appendix
Chand, M. (2023). Most Common C# Dictionary Code Examples. [online] www.c-sharpcorner.com. Available at: https://www.c-sharpcorner.com/UploadFile/mahesh/dictionary-in-C-Sharp/.
Life, S. (2022). What are the different food groups? A simple explanation. [online] South Africans with Diabetes. Available at: https://sweetlife.org.za/what-are-the-different-food-groups-a-simple-explanation/.
Microsoft (2023). Create UIs with Visual Studio XAML Designer - Visual Studio (Windows). [online] learn.microsoft.com. Available at: https://learn.microsoft.com/en-us/visualstudio/xaml-tools/creating-a-ui-by-using-xaml-designer-in-visual-studio?view=vs-2022.
Microsoft (n.d.). Download .NET Framework | Free official downloads. [online] Microsoft. Available at: https://dotnet.microsoft.com/en-us/download/dotnet-framework.
Microsoft (2024). Install Visual Studio. [online] learn.microsoft.com. Available at: https://learn.microsoft.com/en-us/visualstudio/install/install-visual-studio?view=vs-2022.
Saini, A. (2019). C# Dictionary with examples. [online] GeeksforGeeks. Available at: https://www.geeksforgeeks.org/c-sharp-dictionary-with-examples/.
Troelsen, A. and Japikse, P. (2022). Pro C# 10 with .NET 6. Apress.




