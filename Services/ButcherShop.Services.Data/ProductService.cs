namespace ButcherShop.Services.Data
{
    using System.Linq;
    using System.Threading.Tasks;

    using ButcherShop.Data.Common.Repositories;
    using ButcherShop.Data.Models;
    using ButcherShop.Web.ViewModels.Products;

    public class ProductService : IProductService
    {
        private IDeletableEntityRepository<Product> productsRepo;
        private IDeletableEntityRepository<Category> categoryRepo;

        public ProductService(IDeletableEntityRepository<Product> productsRepo, IDeletableEntityRepository<Category> categoryRepo)
        {
            this.productsRepo = productsRepo;
            this.categoryRepo = categoryRepo;
        }

        public async Task CreateAsync(CreateProductInputModel input)
        {
            var dbcategories = this.categoryRepo.All();
            var product = new Product()
            {
                Name = input.Name,
                PricePerKg = input.PricePerKg,
            };
            foreach (var inputCategory in input.Categories)
            {
                product.Categories.Add(new ProductCategory() { Product = product, Category = dbcategories.FirstOrDefault(x => x.Name == inputCategory) });
            }

            await this.productsRepo.AddAsync(product);
            await this.productsRepo.SaveChangesAsync();
        }
    }
}
