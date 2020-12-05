namespace ButcherShop.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ButcherShop.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            this.Products = new HashSet<ProductCategory>();
        }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<ProductCategory> Products { get; set; }
    }
}
