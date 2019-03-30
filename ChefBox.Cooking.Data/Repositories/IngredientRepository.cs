using ChefBox.Cooking.Dto.Ingredient;
using ChefBox.Cooking.IData.interfaces;
using ChefBox.Model.Cooking;
using ChefBox.SqlServer.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChefBox.Cooking.Data.Repositories
{
    public class IIngredientRepository : IIngredientRepositry

    {
        public ChefBoxDbContext Context { get; }

        public IIngredientRepository(ChefBoxDbContext context)
        {
            Context = context;
        }

        public IngredientDto ActionIngredient(IngredientDto ingredientDto)
        {
            Ingredient ingredientEntity = Context.Ingredients
              .SingleOrDefault(ing =>ing.IsValid
                                  &&
               ing.Id == ingredientDto.Id);
            EntityState entityState = EntityState.Modified;
            if (ingredientEntity == null)
            {
              
                ingredientEntity = new Ingredient()
                {
                    Name = ingredientDto.Name,
                    Description = ingredientDto.Description
                };
                entityState = EntityState.Added;
            }
            else
            {
                ingredientEntity.Name = ingredientEntity.Name;
                ingredientEntity.Description = ingredientEntity.Description;
            }
            Context.Entry(ingredientEntity).State = entityState;
            Context.SaveChanges();
            ingredientDto.Id = ingredientEntity.Id;
            return ingredientDto;

        }

        public IEnumerable<IngredientDto> GetIngredient(string query)
        {
            return Context.Ingredients
                .Where(ing =>
                        ing.IsValid
                        &&
                        (
                            string.IsNullOrEmpty(query)
                            ||
                            ing.Name.ToUpper().Contains(query.ToUpper())
                        )
                    )
                    .Select(ing => new IngredientDto()
                    {
                        Id = ing.Id,
                        Name = ing.Name,
                        Description = ing.Description,
                        RecipesCount = ing.RecipeIngredients.Count(recIng => recIng.IsValid)
                    })
                    .ToList();
        }

        public bool RemoveIngredient(int id)
        {
            var ingredientEntity = Context.Ingredients
                    .SingleOrDefault(ing => ing.IsValid && ing.Id == id);
            if (ingredientEntity != null)
            {
                ingredientEntity.IsValid = false;
                Context.Update(ingredientEntity);
                Context.SaveChanges();
            }
            return true;
        }
    }
}
