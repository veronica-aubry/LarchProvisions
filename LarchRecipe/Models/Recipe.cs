using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LarchRecipe.Models
{
    public class Recipe
    {  
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public int Servings { get; set; }
    }

    public class RecipesDBContext : DbContext
    {
        public DbSet<Recipe> Recipe { get; set; }
    }

}