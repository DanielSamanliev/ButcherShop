namespace ButcherShop.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

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

        public virtual RecipeImage Image { get; set; }

        public string Instructions { get; set; }

        public virtual ICollection<RecipeIngredient> Ingredients { get; set; }

        public virtual ICollection<RecipeProduct> Products { get; set; }
    }
}
