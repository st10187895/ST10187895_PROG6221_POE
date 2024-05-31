using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10187895_PROG6221_POE
{
    //RecipeBook class creates list of type Recipe to store recipes created by the user
    public class RecipeBook
    {
       
        private List<Recipe> _recipes;
        //instatiate _recipes list
        public RecipeBook()
        {
            _recipes = new List<Recipe>();
        }

        //AddRecipe() method adds recipes to the recipe List using a constructor of type Recipe
        public void AddRecipe(Recipe recipe)
        {
            _recipes.Add(recipe);
        }

        //Remove() method removes recipes from the recipe List using a constructor of type Recipe

        public bool Remove(Recipe recipe)
        {
            return _recipes.Remove(recipe);
        }

        //FindRecipeByName() method is used to pass costructor of type string to find the name of a recipe in the list
        public Recipe FindRecipeByName(string name)
        {
            return _recipes.Find(recipe => recipe.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
        public IEnumerator<Recipe> GetEnumerator()
        {
            return _recipes.GetEnumerator();
        }

        public IEnumerable<Recipe> GetAllRecipes()
        {
            return _recipes;
        }
    }
}
//****************************************************END OF FILE********************************************************************

