using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10187895_PROG6221_POE
{
    //class step is used to add steps to the recipe
    public class Step
    {
        public string step { get; set; }
       
//Step() method uses a constructor of type string to pass each step
        public Step(string step)
        {
            this.step = step;
        }

        public override string ToString()
        {
            return $"{this.step}";
        }
    }
}
//****************************************************END OF FILE********************************************************************

