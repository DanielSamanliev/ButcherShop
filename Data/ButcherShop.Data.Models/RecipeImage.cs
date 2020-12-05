namespace ButcherShop.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    using ButcherShop.Data.Common.Models;

    public class RecipeImage : BaseDeletableModel<string>
    {
        public RecipeImage()
        {
            this.Id = "Recipe" + Guid.NewGuid().ToString();
        }

        public string Extension { get; set; }

        [ForeignKey(nameof(Recipe))]
        public int RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }

        // The contents of the image is in the file system
    }
}
