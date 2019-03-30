using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChefBox.Models;
using ChefBox.Cooking.Data.Repositories;

namespace ChefBox.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IIngredientRepository ingredientRepository)
        {

        }
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
