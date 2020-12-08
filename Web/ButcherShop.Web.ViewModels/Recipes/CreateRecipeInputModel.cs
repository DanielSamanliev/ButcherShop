namespace ButcherShop.Web.ViewModels.Recipes
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class CreateRecipeInputModel
    {
        [Required]
        [MinLength(5)]
        [MaxLength(30)]
        public string Name { get; set; }

        [Display(Name = "Preperation time in minutes")]
        [Range(1, 5 * 24 * 60)]
        public int PrepTime { get; set; }

        [Required]
        [MinLength(10)]
        public string Instructions { get; set; }

        public ICollection<CreateRecipeIngredientInputModel> Ingredients { get; set; }

        public ICollection<CreateRecipeProductInputModel> Products { get; set; }

        public IEnumerable<KeyValuePair<int, string>> ProductsSelector { get; set; }
    }
}
