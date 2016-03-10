using LarchRecipe.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LarchRecipe.Models
{
    public class Recipe
    {
        private RecipesDBContext db = new RecipesDBContext();

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public int Servings { get; set; }

        public string GetName()
        {
            return Name;
        }
    }

    public class Ingredient
    {
        private RecipesDBContext db = new RecipesDBContext();

        public int ID { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public double Amount { get; set; }
        public string Unit { get; set; }
        public int RecipeId { get; set; }

        public double SingleServing()
        {
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

        /*I am trying to take the recipe ID that was entered and get the recipes name from that */

        public class UnitDisplayUpdate
        {
            private int cup { get; set; }
            private int pint { get; set; }
            private int quart { get; set; }
            private int gallon { get; set; }
            private int floz { get; set; }
            private int tbsp { get; set; }
            private int tsp { get; set; }
            private int pound { get; set; }
            private int unit { get; set; }

            public double Cup()
            {
                double cup = 1;
                return cup;
            }

            public double CupToPint()
            {
                double CupToPint = cup / 2;
                return CupToPint;
            }

            public double CupToQuart()
            {
                double CupToQuart = cup / 4;
                return CupToQuart;
            }

            public double CupToGallon()
            {
                double CupToGallon = cup / 16;
                return CupToGallon;
            }

            public double CupToFloz()
            {
                double CupToFloz = cup * 8;
                return CupToFloz;
            }

            public double CupToTbsp()
            {
                double CupToTbsp = cup * 16;
                return CupToTbsp;
            }

            public double CupToTsp()
            {
                double CupToTsp = cup * 48;
                return CupToTsp;
            }

            public double Pound()
            {
                double pound = 1;
                return pound;
            }

            public double PoundToGram()
            {
                double PoundToGram = pound * 454;
                return PoundToGram;
            }

            public double PoundToOz()
            {
                double PoundToOz = pound * 16;
                return PoundToOz;
            }

            public string UnitConverter()
            {
                RecipesDBContext db = new RecipesDBContext();

                var ingredients = from i in db.Ingredients
                                  select i;

                ingredients = ingredients.Where(s => s.Unit.Contains("cup"));
                double updatedAmount = 0;
                foreach (Ingredient ingredient in ingredients)
                {
                    updatedAmount = ingredient.SingleServing();
                    ingredient.Amount = updatedAmount;
                    ingredient.Unit = "cup";
                }
                return updatedAmount.ToString();
            }
        }
    }

    public class RecipesDBContext : DbContext
    {
        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}