namespace ButcherShop.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using ButcherShop.Data.Models;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            await dbContext.Categories.AddAsync(new Category { Name = "Pork" });
            await dbContext.Categories.AddAsync(new Category { Name = "Beef" });
            await dbContext.Categories.AddAsync(new Category { Name = "Chicken" });
            await dbContext.Categories.AddAsync(new Category { Name = "Turkey" });
            await dbContext.Categories.AddAsync(new Category { Name = "BBQ" });
            await dbContext.Categories.AddAsync(new Category { Name = "Pantry" });
            await dbContext.Categories.AddAsync(new Category { Name = "Lamb" });
            await dbContext.Categories.AddAsync(new Category { Name = "Game" });

            await dbContext.SaveChangesAsync();
        }
    }
}
