namespace ButcherShop.Services.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using ButcherShop.Data.Common.Repositories;
    using ButcherShop.Data.Models;
    using ButcherShop.Web.ViewModels.Recipes;

    public class RecipeService : IRecipeService
    {
        private IDeletableEntityRepository<Recipe> recipeRepo;
        private IDeletableEntityRepository<Ingredient> ingredientRepo;

        public RecipeService(
            IDeletableEntityRepository<Recipe> recipeRepo,
            IDeletableEntityRepository<Ingredient> ingredientRepo)
        {
            this.recipeRepo = recipeRepo;
            this.ingredientRepo = ingredientRepo;
        }

        public async Task CreateAsync(CreateRecipeInputModel input)
        {
            var recipe = new Recipe()
            {
                Name = input.Name,
                PrepTime = TimeSpan.FromMinutes((double)input.PrepTime),
                Instructions = input.Instructions,
            };

            foreach (var inputProduct in input.Products)
            {
                recipe.Products.Add(new RecipeProduct()
                {
                    ProductId = inputProduct.Id,
                    Quantity = inputProduct.Quantity,
                });
            }

            foreach (var inputIngredient in input.Ingredients)
            {
                var ingredient = this.ingredientRepo.All().FirstOrDefault(x => x.Name == inputIngredient.Name);
                if (ingredient == null)
                {
                    ingredient = new Ingredient()
                    {
                        Name = inputIngredient.Name,
                    };
                }

                recipe.Ingredients.Add(new RecipeIngredient()
                {
                    Ingredient = ingredient,
                    Quantity = inputIngredient.Quantity,
                });
            }

            await this.recipeRepo.AddAsync(recipe);
            await this.recipeRepo.SaveChangesAsync();
        }
    }
}
