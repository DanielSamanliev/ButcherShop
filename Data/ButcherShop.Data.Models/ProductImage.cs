namespace ButcherShop.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    using ButcherShop.Data.Common.Models;

    public class ProductImage : BaseDeletableModel<string>
    {
        public ProductImage()
        {
            this.Id = "Product" + Guid.NewGuid().ToString();
        }

        public string Extension { get; set; }

        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        // The contents of the image is in the file system
    }
}
