namespace ButcherShop.Services.Data
{
    using ButcherShop.Web.ViewModels.Home;

    public interface IGetInfoCountsService
    {
        IndexViewModel GetProductRecipeCategoryCounts();
    }
}
