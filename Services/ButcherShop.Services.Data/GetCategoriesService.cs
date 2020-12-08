namespace ButcherShop.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using ButcherShop.Data.Common.Repositories;
    using ButcherShop.Data.Models;

    public class GetCategoriesService : IGetCategoriesService
    {
        private IDeletableEntityRepository<Category> categories;

        public GetCategoriesService(IDeletableEntityRepository<Category> categories)
        {
            this.categories = categories;
        }

        public IEnumerable<string> GetAsStringEnumerable()
        {
            return this.categories.AllAsNoTracking().ToList().Select(x => x.Name);
        }
    }
}
