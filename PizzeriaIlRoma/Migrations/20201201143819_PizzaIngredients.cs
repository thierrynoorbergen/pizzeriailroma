using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzeriaIlRoma.Migrations
{
    public partial class PizzaIngredients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PizzaIngredients_Ingredients_IngredientId",
                table: "PizzaIngredients");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaIngredients_Pizzas_PizzaId",
                table: "PizzaIngredients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PizzaIngredients",
                table: "PizzaIngredients");

            migrationBuilder.RenameTable(
                name: "PizzaIngredients",
                newName: "PizzaIngredient");

            migrationBuilder.RenameIndex(
                name: "IX_PizzaIngredients_PizzaId",
                table: "PizzaIngredient",
                newName: "IX_PizzaIngredient_PizzaId");

            migrationBuilder.RenameIndex(
                name: "IX_PizzaIngredients_IngredientId",
                table: "PizzaIngredient",
                newName: "IX_PizzaIngredient_IngredientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PizzaIngredient",
                table: "PizzaIngredient",
                column: "PizzaIngredientId");

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaIngredient_Ingredients_IngredientId",
                table: "PizzaIngredient",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaIngredient_Pizzas_PizzaId",
                table: "PizzaIngredient",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PizzaIngredient_Ingredients_IngredientId",
                table: "PizzaIngredient");

            migrationBuilder.DropForeignKey(
                name: "FK_PizzaIngredient_Pizzas_PizzaId",
                table: "PizzaIngredient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PizzaIngredient",
                table: "PizzaIngredient");

            migrationBuilder.RenameTable(
                name: "PizzaIngredient",
                newName: "PizzaIngredients");

            migrationBuilder.RenameIndex(
                name: "IX_PizzaIngredient_PizzaId",
                table: "PizzaIngredients",
                newName: "IX_PizzaIngredients_PizzaId");

            migrationBuilder.RenameIndex(
                name: "IX_PizzaIngredient_IngredientId",
                table: "PizzaIngredients",
                newName: "IX_PizzaIngredients_IngredientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PizzaIngredients",
                table: "PizzaIngredients",
                column: "PizzaIngredientId");

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaIngredients_Ingredients_IngredientId",
                table: "PizzaIngredients",
                column: "IngredientId",
                principalTable: "Ingredients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PizzaIngredients_Pizzas_PizzaId",
                table: "PizzaIngredients",
                column: "PizzaId",
                principalTable: "Pizzas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
