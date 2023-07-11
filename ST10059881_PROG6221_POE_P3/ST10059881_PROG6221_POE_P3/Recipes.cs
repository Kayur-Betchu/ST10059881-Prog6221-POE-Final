using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10059881_PROG6221_POE_P3
{
    internal class Recipes
    {
        public string RecipeName { get; set; }

        public List<string> Steps { get; set; }

        public List<Ingredients> ingredients { get; set;}

        public Recipes() 
        { 

        }

        public Recipes(string recipeName, List<string> steps, List<Ingredients> ingredients)
        {
            RecipeName = recipeName;
            Steps = steps;
            this.ingredients = ingredients;
        }

    }
}
