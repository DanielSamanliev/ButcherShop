namespace ButcherShop.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class RecipeIngredient
    {
        [ForeignKey(nameof(Recipe))]
        public int RecipeId { get; set; }

        public virtual Recipe Recipe { get; set; }

        [ForeignKey(nameof(Ingredient))]
        public int IngredientId { get; set; }

        public virtual Ingredient Ingredient { get; set; }

        public string Quantity { get; set; }
    }
}
