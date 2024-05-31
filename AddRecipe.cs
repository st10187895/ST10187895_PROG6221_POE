using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10187895_PROG6221_POE
{
    internal class AddRecipe
    {
        public void AddIngredients()
        {

            Console.WriteLine("Please enter the number of Ingredients in your Recipe");
            numIngredients = int.Parse(Console.ReadLine());
            /* this for-loop is used to persist the user for each ingredient, ingredient quantity and unit measurement based on the number 
            of ingredients entered by the user above*/

            for (int i = 0; i < numIngredients; i++)
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
}
