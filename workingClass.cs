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
        public string ingredientName;
        public double ingredientQuant;
        public string unitMeasurement;
        public int recipeSteps;
        public int step;
        public double scale;
        string[] ingredients = new string[0];
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
            Console.WriteLine("Choose an option from the menu below: \n" +
                "1) Add Recipe \n" +
                "2) View Recipe \n" +
                "3) Exit");
            menuOption = int.Parse(Console.ReadLine());
            switch (menuOption)
			{
				case 1:
                    nameRecipe();
                    addIngredients();
					break;
				case 2:
                    DisplayRecipe();
					break;
				case 3:
					Console.WriteLine("Thank you for using the Recipe Management System");
					break;
				
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
            
            Console.WriteLine("Please enter the name of the ingredient: ");
            ingredientName = Console.ReadLine();
            Console.WriteLine("Please enter the quantity: ");
            ingredientQuant = double.Parse(Console.ReadLine());
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("This has worked");

            Console.WriteLine($"RecipeName: \t" + recipeName + 
                                "Number of Ingredients: \t" + numIngredients );

        }

    }
}
