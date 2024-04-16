using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ST10187895_PROG6221_POE
{
    public class workingClass
    {
        public string recipeName;
        public int numIngredients;
        /*public string ingredientName;
        public double ingredientQuant;
        public string unitMeasurement;*/
        public int recipeSteps;
        public int numSteps;
        public double scale;
        string[] ingredients = new string[0];
        double[] ingredientQuant = new double[0];
        string[] unitMeasurement = new string[0];
        string[] steps = new string[0];

        public int menuOption;

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
        public void recipeManagerMenu()
        {
            int exitMenu = 0;
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
                        DisplayRecipe();
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

        public void nameRecipe()
        {
            Console.WriteLine("Enter the name of your recipe");
            recipeName = Console.ReadLine();
        }

        public void addIngredients()
        {
            
            Console.WriteLine("Please enter the number of Ingredients in your Recipe");
            numIngredients = int.Parse(Console.ReadLine());

            for (int i = 0; i< numIngredients; i++)
            {
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
