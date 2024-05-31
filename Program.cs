using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// Name: Thando Fredericks
/// STUDENT: ST10187895
/// Module: PROG6221
///
//************************************************************************************************************************************
namespace ST10187895_PROG6221_POE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuOpen = 0;
            int menuOption;
            string recipeName="";
            var ingredients = new IngredientCollection<Ingredient>();
            var steps = new StepsCollection<Step>();
            var recipeBook = new RecipeBook();
            int exitMenu = 0;
            
            //this while statement is used to return the user to the main menu after completing any function
            while (menuOpen < 1)
            {
                Console.WriteLine("Choose an option from the menu below: \n" +
                    "1) Add Recipe \n" +
                    "2) View Recipe \n" +
                    "3) Clear Recipe \n" +
                    "4) Exit");
                menuOption = int.Parse(Console.ReadLine());
                switch (menuOption)
                {
                    case 1:
                        int ingInput = 0;
                        Console.WriteLine("Please enter the name of your recipe");
                        recipeName = Console.ReadLine();
                        var recipe = new Recipe(recipeName);

                        int numIngr;
                        Console.WriteLine("Please enter the number of ingredients in your Recipe:");
                        while (!int.TryParse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out numIngr))
                        {
                            Console.WriteLine("Invalid input. Please enter a numeric value for number of Ingredients: ");
                        }
                        for (int i = 0;i<numIngr;i++)
                        {                     
                            Console.WriteLine("Enter the name of a ingredient: ");
                            var userInput = Console.ReadLine();
                            string name = userInput;
                           
                           Console.WriteLine($"Enter quantity of {userInput} (numeric value only): ");
                            double quantity;
                            while (!double.TryParse(Console.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out quantity))
                            {
                                Console.WriteLine("Invalid input. Please enter a numeric value for quantity: ");
                            }

                            Console.Write("Enter unit of measurement \n " +
                                "(e.g cups, ml, grams etc...) ");
                            string unit = Console.ReadLine();

                            Console.WriteLine($"Please enter the food group {name} belongs to");
                            string foodgroup = Console.ReadLine();

                            Console.WriteLine($"Please enter the number of calories in {name}");
                            int calories;
                            while (!int.TryParse(Console.ReadLine(), NumberStyles.Integer, CultureInfo.InvariantCulture, out calories))
                            {
                                Console.WriteLine("Invalid input. Please enter a numeric value for calories: ");
                            }
                           

                            ingredients.Add(new Ingredient(name, quantity, unit,foodgroup,calories));                            
                        }
                        Console.WriteLine("Ingredients Captured!");
                        recipe.AddIngredients(ingredients);

                        Console.WriteLine("How many steps are in your recipe?");
                        int numSteps = int.Parse(Console.ReadLine());
                        for(int i = 1; i < numSteps + 1; i++)
                        {
                            Console.WriteLine($"Enter Step {i} of your recipe");
                            string aStep = Console.ReadLine();
                            steps.Add(new Step(aStep));
                        }
                        Console.WriteLine("Steps Captured");
                        recipe.AddSteps(steps);
                        recipeBook.AddRecipe(recipe);

                        break;
                    case 2:
                        while (true)
                        {
                            Console.WriteLine("Your Recipe Book:");
                            foreach(var Recipe in recipeBook)
                            {
                                Console.WriteLine(Recipe.Name);
                            }
                            Console.WriteLine("");
                            Console.WriteLine("Enter the name of the recipe to view (or 'done' to finish): ");
                            string recipeSearch = Console.ReadLine();

                            if (recipeSearch.Equals("done", StringComparison.OrdinalIgnoreCase))
                                break;

                            var findRecipe = recipeBook.FindRecipeByName(recipeSearch);

                            if (findRecipe != null)
                            {
                                Console.WriteLine($"Recipe Name: {findRecipe.Name}");
                                Console.WriteLine("Ingredients \t" + "Quanity \t" + "Measurement\t"+"Total calories\t"+"Food Group");
                                foreach (var ingredient in findRecipe.GetAllIngredients())
                                {
                                    Console.WriteLine($"{ingredient.Name}                    \t"+$"{ingredient.Quantity}              \t"+$"{ingredient.Unit}                   \t"+$"{ingredient.foodGroup}");
                                }
                                Console.WriteLine("");
                                Console.WriteLine("instructions: ");

                                int count = 1;
                                foreach (Step step in findRecipe.GetAllSteps())
                                {
                                    Console.WriteLine($"{count}) {step}");
                                    count++;
                                }   
                            }
                            else
                            {
                                Console.WriteLine($"\nRecipe '{recipeSearch}' not found.");
                            }

                        }
                        break;
                    case 3:
                        string recipeToDelete;
                        Console.WriteLine("Your Recipe Book");
                        foreach (var Recipe in recipeBook)
                        {
                            Console.WriteLine(Recipe.Name);
                        }
                        Console.WriteLine("Please enter the name of the recipe you wish to delete");
                        recipeToDelete = Console.ReadLine();

                        var deleteRecipe = recipeBook.FindRecipeByName(recipeToDelete);
                        
                        if(recipeBook.Remove(deleteRecipe) == true)
                        {
                            Console.WriteLine($"{recipeToDelete} recipe has been deleted.");

                        }
                        else
                        {
                            Console.WriteLine($"{recipeToDelete} not found");
                        }


                        break;
                    case 4:
                        Console.WriteLine("Thank you for using the Recipe Management System");
                        Environment.Exit(0);
                        break;

                }
            }
           

        }
    }
}
//****************************************************END OF FILE********************************************************************

