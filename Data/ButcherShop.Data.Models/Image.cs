namespace ButcherShop.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using ButcherShop.Data.Common.Models;

    public class Image : BaseDeletableModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Required]
        public string Extension { get; set; }

        public virtual Product Product { get; set; }

        public virtual Recipe Recipe { get; set; }

        // The contents of the image is in the file system
    }
}
