using ChefBox.Cooking.Dto.Recipy;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefBox.Cooking.IData.interfaces
{
    public interface IRrecipeRepositry
    {
        IEnumerable<RecipeDto> GetRecipe(string query);

    }
}
