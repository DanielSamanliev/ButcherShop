namespace ButcherShop.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class OrderProduct
    {
        [ForeignKey(nameof(Order))]
        public string OrderId { get; set; }

        public virtual Order Order { get; set; }

        [ForeignKey(nameof(ProductId))]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public decimal Quantity { get; set; }

        [NotMapped]
        public decimal GetProductPrice => this.Product.PricePerKg * this.Quantity;
    }
}
