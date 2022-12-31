using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WBWalks.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Walks_WalkDifficulities_WalkDifficulityId",
                table: "Walks");

            migrationBuilder.DropTable(
                name: "WalkDifficulities");

            migrationBuilder.DropIndex(
                name: "IX_Walks_WalkDifficulityId",
                table: "Walks");

            migrationBuilder.DropColumn(
                name: "WalkDifficulityId",
                table: "Walks");

            migrationBuilder.CreateTable(
                name: "WalkDifficulty",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalkDifficulty", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Walks_WalkDifficultyId",
                table: "Walks",
                column: "WalkDifficultyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Walks_WalkDifficulty_WalkDifficultyId",
                table: "Walks",
                column: "WalkDifficultyId",
                principalTable: "WalkDifficulty",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Walks_WalkDifficulty_WalkDifficultyId",
                table: "Walks");

            migrationBuilder.DropTable(
                name: "WalkDifficulty");

            migrationBuilder.DropIndex(
                name: "IX_Walks_WalkDifficultyId",
                table: "Walks");

            migrationBuilder.AddColumn<Guid>(
                name: "WalkDifficulityId",
                table: "Walks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "WalkDifficulities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalkDifficulities", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Walks_WalkDifficulityId",
                table: "Walks",
                column: "WalkDifficulityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Walks_WalkDifficulities_WalkDifficulityId",
                table: "Walks",
                column: "WalkDifficulityId",
                principalTable: "WalkDifficulities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
