using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10059881_PROG6221_POE_P3
{
    internal class Ingredients
    {
        

        public string IngredientName { get; set; }

        public int Calories { get; set; }

        public double Quantity { get; set; }

        public string UnitOfMeasurement { get; set; }

        public string FoodGroup { get; set; }

        //public String Steps { get; set; }

        public Ingredients(string ingredientName, int calories, double quantity, string unitOfMeasurement, string foodGroup /*string steps*/ )
        {
            
            IngredientName = ingredientName;
            Calories = calories;
            Quantity = quantity;
            UnitOfMeasurement = unitOfMeasurement;
            FoodGroup = foodGroup;
            //Steps = steps;
        }
    }
}
