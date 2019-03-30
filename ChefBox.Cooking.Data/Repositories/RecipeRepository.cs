using ChefBox.Cooking.Dto.Recipy;
using ChefBox.Cooking.IData.interfaces;
using ChefBox.SqlServer.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChefBox.Cooking.Data.Repositories
{
    public class RecipeRepository : IRrecipeRepositry
    {
        public ChefBoxDbContext Context { get; }
        public RecipeRepository(ChefBoxDbContext context)
        {
            Context = context;
        }
        public IEnumerable<RecipeDto> GetRecipe(string query)
        {
            return Context.Recipes.Where(rc => rc.Name.ToUpper().Contains(query.ToUpper())).Select(rc => new RecipeDto()
            {
                Id = rc.Id,
                Name = rc.Name,
                Description = rc.Descripton,

            }).ToList();
               
        }
    }
}
