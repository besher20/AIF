using ChefBox.Cooking.Dto.Recipy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChefBox.ViewModels.Recipe
{
    public class IndexViewModel
    {
        public IEnumerable<RecipeDto> Recipes { get; set; }
    }
}
