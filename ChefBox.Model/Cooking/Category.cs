using ChefBox.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ChefBox.Model.Cooking
{
    public class Category : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public ICollection<Recipe> Recipes { get; set; }
    }
}
