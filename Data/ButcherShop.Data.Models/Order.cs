namespace ButcherShop.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Threading.Tasks;
    using ButcherShop.Data.Common.Models;

    public class Order : BaseDeletableModel<string>
    {
        public Order()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Products = new HashSet<OrderProduct>();
        }

        [ForeignKey(nameof(ApplicationUser))]
        public string ApplicationUserId { get; set; }

        public virtual ApplicationUser Customer { get; set; }

        public bool Completed { get; set; }

        public virtual ICollection<OrderProduct> Products { get; set; }

        [NotMapped]
        public decimal TotalPrice => this.Products.Sum(x => x.GetProductPrice);


    }
}
