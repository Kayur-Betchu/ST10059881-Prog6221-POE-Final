using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10059881_PROG6221_POE_P3
{
    internal class Data
    {
        List<string> steps = new List<string>();
        List<Ingredients> ingredients = new List<Ingredients>();
        List<Recipes> recipes = new List<Recipes>();
        private static Data myInstance;

        public static Data MyInstance
    {
        get
        {
            if (myInstance == null)
            {
                myInstance = new Data();
            }
            return myInstance;
        }
    }

        public void AddStep(string step)
        {
            steps.Add(step);
        }

        public List<string> GetSteps()
        {
            return steps;
        }

        public void AddRecipe(Recipes recipe)
        {
            recipes.Add(recipe);
        }

        public List<Recipes> GetRecipes()
        {
            return recipes;
        }

        public void AddIngredient(Ingredients ingredient)
        {
            ingredients.Add(ingredient);
        }

        public List<Ingredients> GetIngredients()
        {
            return ingredients;
        }

        public void ReinitializeSteps()
        {
            steps = new List<string>();
        }

        public void ReinitializeIngredients()
        {
            ingredients = new List<Ingredients>();
        }


        public void ReinitializeRecipes()
        {
            recipes = new List<Recipes>();
        }

        public List<Recipes> CallRecipes(string x)
        {
            List<Recipes> filteredRecipes = new List<Recipes>();
            for (int i = 0; i < recipes.Count; i++)
            {
                Ingredients r = recipes[i].ingredients.Find(z => z.IngredientName.Equals(x));

                if (r != null)
                {
                    filteredRecipes.Add(recipes[i]);
                }
            }
            
            return filteredRecipes;
        }

        public List<Ingredients> CallScale(Recipes recipes, int scaleFactor)
        {
            List<Ingredients> callScaleList = new List<Ingredients>();
            for (int i = 0; i < recipes.ingredients.Count; i++)
            {
                callScaleList.Add(new Ingredients(recipes.ingredients[i].IngredientName, recipes.ingredients[i].Calories, recipes.ingredients[i].Quantity * scaleFactor, recipes.ingredients[i].UnitOfMeasurement, recipes.ingredients[i].FoodGroup  ));
            }
            return callScaleList;
        }
    }
}
