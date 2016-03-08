using LarchRecipe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LarchRecipe.Controllers
{
    public class HomeController : Controller
    {
        private RecipesDBContext db = new RecipesDBContext();

        Repository _repository = new Repository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        // GET: Home/ViewBagDemo/1
        public ActionResult ViewBagDemo(int? id)
        {
            ViewBag.Recipe = db.Recipe.Find(id);
            ViewBag.Ingredient = _repository.GetRecipeIngredients(id);
            return View();
        }
    }
}