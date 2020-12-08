namespace ButcherShop.Services.Data
{
    using System.Threading.Tasks;

    using ButcherShop.Web.ViewModels.Recipes;

    public interface IRecipeService
    {
        Task CreateAsync(CreateRecipeInputModel input);
    }
}
