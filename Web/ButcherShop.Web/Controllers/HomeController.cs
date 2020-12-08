namespace ButcherShop.Web.Controllers
{
    using System.Diagnostics;

    using ButcherShop.Services.Data;
    using ButcherShop.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private IGetInfoCountsService infoCountsService;

        public HomeController(IGetInfoCountsService infoCountsService)
        {
            this.infoCountsService = infoCountsService;
        }

        public IActionResult Index()
        {
            var viewModel = this.infoCountsService.GetProductRecipeCategoryCounts();
            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
