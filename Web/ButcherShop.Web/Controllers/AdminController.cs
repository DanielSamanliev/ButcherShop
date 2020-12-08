namespace ButcherShop.Web.Controllers
{
    using System.Threading.Tasks;

    using ButcherShop.Services.Data;
    using ButcherShop.Web.ViewModels.Products;
    using ButcherShop.Web.ViewModels.Recipes;
    using Microsoft.AspNetCore.Mvc;

    public class AdminController : Controller
    {
        private IGetCategoriesService getCategoriesService;
        private IProductService productService;
        private IGetProductsService getProductsService;
        private IRecipeService recipeService;

        public AdminController(
            IGetCategoriesService getCategoriesService,
            IProductService productService,
            IGetProductsService getProductsService,
            IRecipeService recipeService)
        {
            this.getCategoriesService = getCategoriesService;
            this.productService = productService;
            this.getProductsService = getProductsService;
            this.recipeService = recipeService;
        }

        public IActionResult CreateProduct()
        {
            var viewModel = new CreateProductInputModel();
            viewModel.Categories = this.getCategoriesService.GetAsStringEnumerable();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.Categories = this.getCategoriesService.GetAsStringEnumerable();
                return this.View(input);
            }

            await this.productService.CreateAsync(input);

            return this.Redirect("/");
        }

        public IActionResult CreateRecipe()
        {
            var viewModel = new CreateRecipeInputModel();
            viewModel.ProductsSelector = this.getProductsService.GetProductsIdName();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRecipe(CreateRecipeInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.ProductsSelector = this.getProductsService.GetProductsIdName();
                return this.View(input);
            }

            await this.recipeService.CreateAsync(input);

            return this.Redirect("/");
        }
    }
}
