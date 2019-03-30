using ChefBox.Model.Base;
using System.ComponentModel.DataAnnotations;

namespace ChefBox.Model.Cooking
{
    public class Photo:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string Url { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}