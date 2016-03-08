using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LarchRecipe.Models;

namespace LarchRecipe.Models
{
    public class Repository
    {

 
        public List<Recipe> GetRecipes()
        {
            RecipesDBContext db = new RecipesDBContext();
            List<Recipe> recipes = new List<Recipe>{ };
            foreach (var i in db.Recipe)
            {
                recipes.Add(i);
            }

            return recipes;
        }


        public List<Ingredient> GetIngredients()
        {
            IngredientDBContext db = new IngredientDBContext();
            List<Ingredient> ingredients = new List<Ingredient> { };
            foreach (var i in db.Ingredients)
            {
                ingredients.Add(i);
            }
                          
            return ingredients;
        }


    }
}