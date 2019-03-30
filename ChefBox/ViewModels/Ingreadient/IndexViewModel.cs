using ChefBox.Cooking.Dto.Ingredient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChefBox.ViewModels.Ingreadient
{
    public class IndexViewModel
    {

        public IEnumerable<IngredientDto> Ingredients { get; set; }

    }
}
