namespace LarchRecipe.Migrations
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LarchRecipe.Models.RecipesDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LarchRecipe.Models.RecipesDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var recipes = new List<Recipe>
            {
                new Recipe { Name = "Pork Empanadas" , Description = "with Currants & Green Olives, with Chimicurri & Spicy Aioli Dipping Sauces", Servings = 4},
                new Recipe { Name = "Ragout", Description = "Pepper, Kale & Corona Bean", Servings = 8 }
            };
            recipes.ForEach(s => context.Recipe.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();

            var ingredients = new List<Ingredient>
            {
                new Ingredient { Name = "Currents", Amount = .75, Unit = "cups", RecipeId = 1 },
                new Ingredient { Name = "Green Olives", Amount = 2, Unit = "cups", RecipeId = 1 },
                new Ingredient { Name = "Chimichurri", Amount = 1.5, Unit = "cups", RecipeId = 1 },
                new Ingredient { Name = "Vegetable Oil", Amount = 2, Unit = "cups", RecipeId = 1 },
                new Ingredient { Name = "Egg Whites", Amount = 6, Unit = "eggs", RecipeId = 1 },
                new Ingredient { Name = "Pepper", Amount = 2, Unit = "Tbsp", RecipeId = 2  },
                new Ingredient { Name = "Kale", Amount = 2, Unit = "main stem", RecipeId = 2 },
                new Ingredient { Name = "Corona Bean", Amount = 6, Unit = "cups", RecipeId = 2, Source = "soaked and drained" }
            };
            ingredients.ForEach(s => context.Ingredients.AddOrUpdate(p => p.Name, s));
            context.SaveChanges();
        }
    }
}