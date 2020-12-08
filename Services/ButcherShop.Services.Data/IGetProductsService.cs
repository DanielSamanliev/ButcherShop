namespace ButcherShop.Services.Data
{
    using System.Collections.Generic;

    public interface IGetProductsService
    {
        public IEnumerable<KeyValuePair<int, string>> GetProductsIdName();
    }
}
