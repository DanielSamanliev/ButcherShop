namespace ButcherShop.Services.Data
{
    using System.Threading.Tasks;

    using ButcherShop.Web.ViewModels.Products;

    public interface IProductService
    {
        Task CreateAsync(CreateProductInputModel input);
    }
}
