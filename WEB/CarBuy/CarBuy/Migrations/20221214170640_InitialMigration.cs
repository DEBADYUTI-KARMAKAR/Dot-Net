using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBuy.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Card",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(name: "Image_Path", type: "nvarchar(max)", nullable: true),
                    Carno = table.Column<int>(name: "Car_no", type: "int", nullable: false),
                    ModelName = table.Column<string>(name: "Model_Name", type: "nvarchar(max)", nullable: false),
                    Carage = table.Column<string>(name: "Car_age", type: "nvarchar(max)", nullable: false),
                    Carbaseprice = table.Column<int>(name: "Car_base_price", type: "int", nullable: false),
                    Carinsurenceprice = table.Column<int>(name: "Car_insurence_price", type: "int", nullable: false),
                    Cartax = table.Column<int>(name: "Car_tax", type: "int", nullable: false),
                    Carins = table.Column<int>(name: "Car_ins", type: "int", nullable: false),
                    Sellingprice = table.Column<int>(name: "Selling_price", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Card", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Card");
        }
    }
}
