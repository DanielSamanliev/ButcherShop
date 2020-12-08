namespace ButcherShop.Web.ViewModels.Recipes
{
    using System.ComponentModel.DataAnnotations;

    public class CreateRecipeProductInputModel
    {
        public int Id { get; set; }

        [Required]
        public string Quantity { get; set; }
    }
}
