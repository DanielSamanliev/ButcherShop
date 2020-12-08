namespace ButcherShop.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class RecipeProduct
    {
        [ForeignKey(nameof(Recipe))]
        public int RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public string Quantity { get; set; }
    }
}
