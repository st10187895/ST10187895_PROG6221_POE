using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10187895_PROG6221_POE
{
    //The Generic collection IngredientCollection<T> is used to created a list of ingredients entered by the user when the program is run
    public class IngredientCollection<T> : IEnumerable<T> where T : Ingredient
    {
        //instatiating the generic list
        private List<T> _ingredients = new List<T>();

        //the Add() method passes argument of type T to the  list
        public void Add(T ingredient)
        {
            _ingredients.Add(ingredient);
        }
        //Remove() removes ingredients from the list
        public bool Remove(T ingredient)
        {
            return _ingredients.Remove(ingredient);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _ingredients.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _ingredients.GetEnumerator();
        }

        public override string ToString()
        {
            return string.Join(", ", _ingredients);
        }
    }
}
//****************************************************END OF FILE********************************************************************

