namespace ButcherShop.Web.ViewModels.Products
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using ButcherShop.Data.Models;

    public class CreateProductInputModel
    {
        [Required]
        public string Name { get; set; }

        [Range(0.1, 1000)]
        [Display(Name = "Price Per Kg")]
        public decimal PricePerKg { get; set; }


        public IEnumerable<string> Categories { get; set; }
    }
}
