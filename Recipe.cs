using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10187895_PROG6221_POE
{
    //The recipe class is used to create a collection of ingredients and steps of a recipe such that information related to a recipe can be found using the name of the Recipe
    public class Recipe
    {
        //instantiating the ingredients and steps collections
        public string Name { get; set; }
        private IngredientCollection<Ingredient> _ingredients;
        private StepsCollection<Step> _steps;

        public Recipe(string name)
        {
            Name = name;
            _ingredients = new IngredientCollection<Ingredient>();
            _steps = new StepsCollection<Step>();
        }

        //AddIngredients passes each ingredient from the ingredient collection in IngredientCollection.cs to this class
        public void AddIngredients(IngredientCollection<Ingredient> ingredients)
        {
            foreach (var ingredient in ingredients)
            {
                _ingredients.Add(ingredient);
            }
        }

        //AddSteps passes each step from the step collection in StepstCollection.cs to this class

        public void AddSteps(StepsCollection<Step> steps)
        {
            foreach(var step in steps)
            {
                _steps.Add(step);
            }
        }
        //Allows for all steps to be returned to the user or relevant method
        public IEnumerable<Ingredient> GetAllIngredients()
        {
            return _ingredients;
        }

        //Allows for all steps to be returned to the user or relevant method
        public IEnumerable<Step> GetAllSteps()
        {
            return _steps;
        }
        public override string ToString()
        {
            return $"{Name}: {string.Join(", ", _ingredients)}";
        }
    }
}
