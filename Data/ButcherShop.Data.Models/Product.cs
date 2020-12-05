namespace ButcherShop.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ButcherShop.Data.Common.Models;

    public class Product : BaseDeletableModel<int>
    {
        public Product()
        {
            this.Recipes = new HashSet<RecipeProduct>();
            this.Images = new HashSet<ProductImage>();
            this.Orders = new HashSet<OrderProduct>();
            this.Categories = new HashSet<ProductCategory>();
        }

        [Required]
        public string Name { get; set; }

        public decimal? OldPricePerKg { get; set; }

        public decimal PricePerKg { get; set; }

        public virtual ICollection<ProductCategory> Categories { get; set; }

        public virtual ICollection<OrderProduct> Orders { get; set; }

        public virtual ICollection<RecipeProduct> Recipes { get; set; }

        public virtual ICollection<ProductImage> Images { get; set; }
    }
}
