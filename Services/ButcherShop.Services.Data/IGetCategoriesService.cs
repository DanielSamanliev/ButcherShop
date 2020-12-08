namespace ButcherShop.Services.Data
{
    using System.Collections.Generic;

    public interface IGetCategoriesService
    {
        public IEnumerable<string> GetAsStringEnumerable();
    }
}
