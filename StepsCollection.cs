using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10187895_PROG6221_POE
{
    //the Generic collection StepsCollection<T> is used to to add steps to a list
    public class StepsCollection<T> : IEnumerable<T> where T : Step
    {
        //instatiating the list
        private List<T> recipeSteps = new List<T>();

        //the Add(T ingredient) passes a constructor of type T to add steps to the generic list
        public void Add(T ingredient)
        {
            recipeSteps.Add(ingredient);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return recipeSteps.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return recipeSteps.GetEnumerator();
        }
    }
}
//****************************************************END OF FILE********************************************************************

