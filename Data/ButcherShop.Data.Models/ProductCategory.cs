namespace ButcherShop.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class ProductCategory
    {
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
