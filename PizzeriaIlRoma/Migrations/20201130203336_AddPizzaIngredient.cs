using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzeriaIlRoma.Migrations
{
    public partial class AddPizzaIngredient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Pizzas_PizzaID",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_PizzaID",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "PizzaID",
                table: "Ingredients");

            migrationBuilder.AlterColumn<int>(
                name: "ID",
                table: "Ingredients",
                type: "int",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateTable(
                name: "PizzaIngredients",
                columns: table => new
                {
                    PizzaIngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PizzaId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaIngredients", x => x.PizzaIngredientId);
                    table.ForeignKey(
                        name: "FK_PizzaIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PizzaIngredients_Pizzas_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "Pizzas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PizzaIngredients_IngredientId",
                table: "PizzaIngredients",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaIngredients_PizzaId",
                table: "PizzaIngredients",
                column: "PizzaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PizzaIngredients");

            migrationBuilder.AlterColumn<Guid>(
                name: "ID",
                table: "Ingredients",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "PizzaID",
                table: "Ingredients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_PizzaID",
                table: "Ingredients",
                column: "PizzaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Pizzas_PizzaID",
                table: "Ingredients",
                column: "PizzaID",
                principalTable: "Pizzas",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
