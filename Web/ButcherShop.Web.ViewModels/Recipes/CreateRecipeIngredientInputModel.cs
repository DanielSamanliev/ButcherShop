
namespace ButcherShop.Web.ViewModels.Recipes
{
    using System.ComponentModel.DataAnnotations;

    public class CreateRecipeIngredientInputModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Quantity { get; set; }
    }
}
