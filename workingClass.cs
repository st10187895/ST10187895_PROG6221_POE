using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
/*references:
https://learn.microsoft.com/en-us/dotnet/api/system.array.resize?view=net-8.0 (used to change array size in addIngredients() and addSteps() methods
*/
namespace ST10187895_PROG6221_POE
{
    public class workingClass
    {
        //Declarations
        public string recipeName;
        public int numIngredients;
        public int recipeSteps;
        public int numSteps;
        public double scale;
        string[] ingredients = new string[0];
        double[] ingredientQuant = new double[0];
        string[] unitMeasurement = new string[0];
        string[] steps = new string[0];
        public int menuOption;

        //The welcomeMenu() method is used as a welcome screen to grant user access to the Recipe Manager Menu
        public  int welcomeMenu()
        {
            Console.WriteLine("Welcome to the Recipe Manager: \n" +
                "\n" +
                "Please enter '1' to start or '2' to exit: \n" +
                "1)Start \n" +
                "2)Exit");
             int startMenuInput = int.Parse(Console.ReadLine());

            return startMenuInput;
        }

        /*The recipeManagerMenu() method serves as a main menu that prompts users to choose an option.
        this method also uses a switch that receives the user input in the form of an int in which each case calls a corresponding method*/
        public void recipeManagerMenu()
        {
            int exitMenu = 0;
            //this while statement is used to return the user to the main menu after completing any function
            while (exitMenu < 1)
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
                        nameRecipe();
                        addIngredients();
                        addSteps();
                        break;
                    case 2:
                        if (numIngredients == 0)
                        {
                            Console.WriteLine("No Recipe has been stored \n" +
                            "Add Recipe first");
                        }
                        else
                        {
                            DisplayRecipe();
                        }
                        break;
                    case 3:
                        clearData();
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using the Recipe Management System");
                        Environment.Exit(0);
                        break;

                }
            }

        }

        // the nameRecipe() method is used to obtain a recipe name from the user
        public void nameRecipe()
        {
            Console.WriteLine("Enter the name of your recipe");
            recipeName = Console.ReadLine();
        }

        // the addIngredients() method prompts the user for information regarding their recipe and adds that information to the corresponding arrays
        public void addIngredients()
        {
            
            Console.WriteLine("Please enter the number of Ingredients in your Recipe");
            numIngredients = int.Parse(Console.ReadLine());
            /* this for-loop is used to persist the user for each ingredient, ingredient quantity and unit measurement based on the number 
            of ingredients entered by the user above*/
            for (int i = 0; i< numIngredients; i++)
            {
                // each array needed to be resized in order to address issues regarding "out of index" errors  
                Array.Resize(ref ingredients, numIngredients);
                Array.Resize(ref ingredientQuant, numIngredients);
                Array.Resize(ref unitMeasurement, numIngredients);

                Console.WriteLine("Please enter the name of the ingredient: ");
                ingredients[i] = Console.ReadLine();
                Console.WriteLine("Please enter the quantity by entering ONLY the numeric value: \n" +
                    "(you will be prompted to include the unit of measurement next)");
                ingredientQuant[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the unit of measurement for the previous value: \n" +
                    "(e.g cups, ml, grams etc...)");
                unitMeasurement[i] = Console.ReadLine();
                }
            Console.WriteLine("Ingredients Captured!");

        }

        //the addSteps() method prompts the user to add each step of their recipe by using a for loop to add each step to a new index
        public void addSteps()
        {
            Console.WriteLine("How many steps are there in your recipe?");
            numSteps = int.Parse(Console.ReadLine());
            for (int k = 0; k < numSteps; k++)
            {
                Array.Resize(ref steps, numIngredients);
                Console.WriteLine($"Enter step {k + 1}");
                steps[k] = Console.ReadLine();
            }
            Console.WriteLine("Steps Captured!");
        }
        /*the DisplayRecipe() method asks the user for the number servings they wish to make and scale the recipe accordingly. 
        This method uses a for loop to output each stored value from the indices of the ingredients[], ingredientsQuant[] and unitMeasurement[] arrays
        This method also displays each step for the recipe by using a for-loop*/
        public void DisplayRecipe()
        {
            Console.WriteLine("How many Servings do you want to make?");
            scale = double.Parse(Console.ReadLine());
            if (scale == 1/2)
            {
                scale = 0.5;
            }

            Console.WriteLine($"RecipeName: " + recipeName + "\n" +
                               "Number of Ingredients: " + numIngredients + "\n" );
            Console.WriteLine("Ingredients \t" + "Quanity \t" + "Measurement");
            
            for (int j = 0; j < ingredients.Length; j++)
            {
                
                Console.WriteLine(ingredients[j] + "\t        " + ingredientQuant[j]*scale + "\t        " + unitMeasurement[j]);
            }
            Console.WriteLine("Steps: ");
            for (int y = 0;y < numSteps; y++)
            {
                Console.WriteLine($"{y+1})" + steps[y]);
            }

        }
        //the clearData method clears all stored values by setting them to null
        public void clearData()
        {
            recipeName = null;
            ingredients = null;
            ingredientQuant = null;
            unitMeasurement = null;
            steps = null;
        }

    }
}
