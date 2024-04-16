using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// Name: Thando Fredericks
/// STUDENT: ST10187895
/// Module: PROG6221
///
//************************************************************************************************************************************
namespace ST10187895_PROG6221_POE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            workingClass recipe = new workingClass();
            //calling the welcomeMenu() method
            if (recipe.welcomeMenu() == 1)
            {
                recipe.recipeManagerMenu();
            }
            else
            {
                Console.WriteLine("Thank you for using the Recipe Manager");
            }
            
        }
    }
}
//****************************************************END OF FILE********************************************************************

