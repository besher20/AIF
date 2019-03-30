using ChefBox.Cooking.Dto.Ingredient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefBox.Cooking.IData.interfaces
{
    public interface IIngredientRepositry
    {
        IEnumerable<IngredientDto> GetIngredient(string query);
        IngredientDto ActionIngredient(IngredientDto ingredientDto);
        bool RemoveIngredient(int id);
    }
}
