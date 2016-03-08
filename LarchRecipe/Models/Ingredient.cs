using System;
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
    }

    public class IngredientDBContext : DbContext
    {
        public DbSet<Ingredient> Ingredients { get; set; }
    }
}