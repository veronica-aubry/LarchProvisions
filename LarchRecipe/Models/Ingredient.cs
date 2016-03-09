﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace LarchRecipe.Models
{
    public class Ingredient
    {
        
        public int ID { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public double Amount { get; set; }
        public string Unit { get; set; }
        public int RecipeId { get; set; }

        public double SingleServing()
        {
            RecipesDBContext db = new RecipesDBContext();
            if (this.RecipeId != 0)
            {
                Recipe recipe = db.Recipe.Find(this.RecipeId);
                       
                double singleServing = this.Amount / recipe.Servings;
                return singleServing;
            }
            else
            {
                return 0;
            }     
        }
    }

    

    public class IngredientDBContext : DbContext
    {
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}