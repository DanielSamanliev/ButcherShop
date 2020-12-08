namespace ButcherShop.Services.Data
{
    using System.Linq;

    using ButcherShop.Data.Common.Repositories;
    using ButcherShop.Data.Models;
    using ButcherShop.Web.ViewModels.Home;

    // Get count of Products, Categories and Recipes for home page
    public class GetInfoCountsService : IGetInfoCountsService
    {
        private IDeletableEntityRepository<Category> categoriesRepository;
        private IDeletableEntityRepository<Product> productsRepository;
        private IDeletableEntityRepository<Recipe> recipiesRepository;

        public GetInfoCountsService(
            IDeletableEntityRepository<Category> categoriesRepository,
            IDeletableEntityRepository<Product> productsRepository,
            IDeletableEntityRepository<Recipe> recipiesRepository)
        {
            this.categoriesRepository = categoriesRepository;
            this.productsRepository = productsRepository;
            this.recipiesRepository = recipiesRepository;
        }

        public IndexViewModel GetProductRecipeCategoryCounts()
        {
            var data = new IndexViewModel
            {
                ProductsCount = this.productsRepository.All().Count(),
                CategoriesCount = this.categoriesRepository.All().Count(),
                RecipesCount = this.recipiesRepository.All().Count(),
            };

            return data;
        }
    }
}
