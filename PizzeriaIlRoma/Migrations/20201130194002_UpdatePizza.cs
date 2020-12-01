using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzeriaIlRoma.Migrations
{
    public partial class UpdatePizza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUri",
                table: "Pizzas",
                newName: "ImageUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Pizzas",
                newName: "ImageUri");
        }
    }
}
