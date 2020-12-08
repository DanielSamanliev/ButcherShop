namespace ButcherShop.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using ButcherShop.Data.Common.Repositories;
    using ButcherShop.Data.Models;

    public class GetProductsService : IGetProductsService
    {
        private IDeletableEntityRepository<Product> productRepo;

        public GetProductsService(IDeletableEntityRepository<Product> productRepo)
        {
            this.productRepo = productRepo;
        }

        public IEnumerable<KeyValuePair<int, string>> GetProductsIdName()
        {
            return this.productRepo.AllAsNoTracking().Select(x => new
            {
                x.Id,
                x.Name,
            }).ToList()
            .Select(x => new KeyValuePair<int, string>(x.Id, x.Name));
        }
    }
}
