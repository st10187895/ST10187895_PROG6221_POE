using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10187895_PROG6221_POE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            workingClass recipe = new workingClass();
            recipe.recipeManagerMenu();
            recipe.addIngredients();
            recipe.DisplayRecipe();
        }
    }
}
