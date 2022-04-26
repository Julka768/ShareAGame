using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShareAGame.DataAccess.Migrations
{
    public partial class AddedGameEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDigital = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "IsDigital", "Name" },
                values: new object[] { new Guid("277eb80b-5574-4728-bdaa-63d25c6847a1"), true, "Lara Croft Tomb Raider" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "IsDigital", "Name" },
                values: new object[] { new Guid("e971fe57-1b27-46d9-9822-88d63b0caa76"), true, "Assasin Creed Valhalla" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "IsDigital", "Name" },
                values: new object[] { new Guid("2ef01f75-7eee-4838-af26-bfb4cf2d0e06"), false, "Watch Dogs" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
