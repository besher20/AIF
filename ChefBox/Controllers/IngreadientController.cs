using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChefBox.Cooking.Data.Repositories;
using ChefBox.Cooking.IData.interfaces;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChefBox.Controllers
{
    public class IngreadientController : Controller
    {
        public IIngredientRepositry IngredientRepository { get; }
        public IngreadientController(IngredientRepository ingredientRepository)
        {
            IngredientRepository = ingredientRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var viewModel = new IndexViewModel()
            {
                Ingredients = IngredientRepository.GetIngredients(null)
            };
            return View(viewModel);
        }
    }
}
