using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChefBox.Cooking.IData.interfaces;
using ChefBox.ViewModels.Recipe;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChefBox.Controllers
{
    public class RecipeController : Controller
    {
        public IRrecipeRepositry RecipeRepository { get; }
        public RecipeController(IRrecipeRepositry recipeRepository)
        {
            RecipeRepository = recipeRepository;

        }

        
         public IActionResult Index()
        {
            var viewModel = new IndexViewModel()
            {
                Recipes = RecipeRepository.GetRecipe(null)
            };

            return View(viewModel);
        }
       


    }
}
