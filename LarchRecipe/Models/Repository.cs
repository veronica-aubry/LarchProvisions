using LarchRecipe.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace LarchRecipe.Models
{
    public class Repository
    {
        private RecipesDBContext db = new RecipesDBContext();

        public List<Recipe> GetRecipes()
        {
            List<Recipe> recipes = new List<Recipe> { };
            foreach (var i in db.Recipe)
            {
                recipes.Add(i);
            }

            return recipes;
        }

        public Recipe GetRecipe(int? id)
        {
            Recipe recipe = new Recipe();
            foreach (var i in db.Recipe)
            {
                if (i.ID == id)
                {
                    recipe = i;
                }
            }

            return recipe;
        }

        public List<Ingredient> GetIngredients()
        {
            List<Ingredient> ingredients = new List<Ingredient> { };
            foreach (var i in db.Ingredients)
            {
                ingredients.Add(i);
            }

            return ingredients;
        }

        public List<Ingredient> GetRecipeIngredients(int? recipeId)
        {
            List<Ingredient> ingredients = new List<Ingredient> { };
            foreach (var i in db.Ingredients)
            {
                if (i.RecipeId == recipeId)
                {
                    ingredients.Add(i);
                }
            }
            return ingredients;
        }
    }
}