namespace ST10187895_PROG6221_POE
{
    //ingredient class is used to set and get ingredient attributes 
    public class Ingredient
    {
        //Declarations
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }
        public string foodGroup { get; set; }
        public int numCalories { get; set; }

        //The Ingredient() method passes multiple arguments to add ingredient information entered by the user when the program is run
        public Ingredient(string name, double quantity, string unit, string foodgroup,int calories)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
            foodGroup = foodgroup;
            numCalories = calories;
        }

        public override string ToString()
        {
            return $"{Quantity} {Unit} of {Name}";
        }
    }
}
//****************************************************END OF FILE********************************************************************
