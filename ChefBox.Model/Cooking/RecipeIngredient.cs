using ChefBox.Model.Base;
using ChefBox.Model.Cooking.Enums;

namespace ChefBox.Model.Cooking
{
    public class RecipeIngredient:BaseEntity
    {
      
        public Recipe Recipe { get; set; }

        public Ingredient Ingredient { get; set; }
        public int IngredientId { get; set; }

        public double Amount { get; set; }
        public Unit Unit { get; set; }
    }
}