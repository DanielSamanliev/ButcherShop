namespace ButcherShop.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using ButcherShop.Data.Common.Models;

    public class Recipe : BaseDeletableModel<int>
    {
        public Recipe()
        {
            this.Ingredients = new HashSet<RecipeIngredient>();
            this.Products = new HashSet<RecipeProduct>();
        }

        [Required]
        public string Name { get; set; }

        public TimeSpan PrepTime { get; set; }

        [ForeignKey(nameof(Models.Image))]
        public string ImageId { get; set; }

        public virtual Image Image { get; set; }

        public string Instructions { get; set; }

        public virtual ICollection<RecipeIngredient> Ingredients { get; set; }

        public virtual ICollection<RecipeProduct> Products { get; set; }
    }
}
