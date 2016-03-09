using LarchRecipe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace LarchRecipe.ViewModels
{
    public class RecipeRepository
    {
        private RecipesDBContext db = new RecipesDBContext();

        //get recipe
        public IQueryable<Ingredient> GetRecipeIngredients(int? id)
        {
            var recipes = from r in db.Ingredients
                          where (r.RecipeId == id)
                          select r;

            return recipes;
        }

        public IQueryable<Ingredient> GetAllIngredients()
        {
            var ingredients = from r in db.Ingredients
                              select r;

            return ingredients;
        }

        public int ID { get; set; }
        public string RecipeName { get; set; }
        public int RecipeId { get; set; }

        public virtual Ingredient Ingredient { get; set; }

        [DisplayName("Recipe Ingredients")]
        public virtual IQueryable<Ingredient> Ingredients { get; set; }
    }
}