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

        public ActionResult ViewBagDemo()
        {
            ViewBag.Recipe = _repository.GetRecipes();
            ViewBag.Ingredient = _repository.GetIngredients();
            return View();
        }
    }
}