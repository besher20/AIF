using ChefBox.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChefBox.Model.Cooking
{
   public class Ingredient:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }


    }
}
