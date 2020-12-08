namespace ButcherShop.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using ButcherShop.Data.Common.Models;

    public class Product : BaseDeletableModel<int>
    {
        public Product()
        {
            this.Recipes = new HashSet<RecipeProduct>();
            this.Orders = new HashSet<OrderProduct>();
            this.Categories = new HashSet<ProductCategory>();
        }

        [Required]
        public string Name { get; set; }

        public decimal? OldPricePerKg { get; set; }

        public decimal PricePerKg { get; set; }

        [ForeignKey(nameof(Models.Image))]
        public string ImageId { get; set; }

        public virtual Image Image { get; set; }

        public virtual ICollection<ProductCategory> Categories { get; set; }

        public virtual ICollection<OrderProduct> Orders { get; set; }

        public virtual ICollection<RecipeProduct> Recipes { get; set; }
    }
}
