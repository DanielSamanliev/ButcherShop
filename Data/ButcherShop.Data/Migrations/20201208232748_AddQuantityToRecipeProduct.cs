using Microsoft.EntityFrameworkCore.Migrations;

namespace ButcherShop.Data.Migrations
{
    public partial class AddQuantityToRecipeProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Quantity",
                table: "RecipesProducts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "RecipesProducts");
        }
    }
}
