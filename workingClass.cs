using System;
using System.Collections.Generic;
using System.Linq;
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

        public void recipeManagerMenu()
        {
            Console.WriteLine("Choose an option from the menu below: \n" +
                "1) Add Recipe \n" +
                "2) View Recipe \n" +
                "3) Exit");
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
            Console.WriteLine("Number of Ing" + numIngredients);

        }

    }
}
