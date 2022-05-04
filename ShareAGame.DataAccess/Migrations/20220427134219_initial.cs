using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShareAGame.DataAccess.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDigital = table.Column<bool>(type: "bit", nullable: false),
                    ReleaseDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublisherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GamePlatform = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                    table.ForeignKey(
                        name: "FK_dbo.game.Publisher_PublisherId",
                        column: x => x.PublisherId,
                        principalTable: "Publishers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("7c7bc643-b767-4614-8724-fe96ecc57eb2"), "Ubisoft" });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("82642b42-06f4-43e5-847c-5433ce42b31b"), "Square Enix" });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "GamePlatform", "ImageUrl", "IsDigital", "Name", "PublisherId", "ReleaseDate" },
                values: new object[] { new Guid("3c54248d-572c-4e2f-861c-d8eb90fcf74d"), 0, "https://cdn1.epicgames.com/400347196e674de89c23cc2a7f2121db/offer/AC%20KINGDOM%20PREORDER_STANDARD%20EDITION_EPIC_Key_Art_Portrait_640x854-640x854-288120c5573756cb988b6c1968cebd86.png", true, "Assasin Creed Valhalla", new Guid("7c7bc643-b767-4614-8724-fe96ecc57eb2"), new DateTimeOffset(new DateTime(2020, 11, 10, 13, 20, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -5, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "GamePlatform", "ImageUrl", "IsDigital", "Name", "PublisherId", "ReleaseDate" },
                values: new object[] { new Guid("9db8341c-dc54-41cb-8ccb-72443da96f0e"), 4, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTaaud_5UmER7n84qaagoWadSzdUnahTfDRNw&usqp=CAU", false, "Watch Dogs", new Guid("7c7bc643-b767-4614-8724-fe96ecc57eb2"), new DateTimeOffset(new DateTime(2014, 5, 26, 13, 20, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -5, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "GamePlatform", "ImageUrl", "IsDigital", "Name", "PublisherId", "ReleaseDate" },
                values: new object[] { new Guid("c5703113-5f0a-4f17-af4f-83b330fa9c8a"), 6, "https://static.wikia.nocookie.net/tombraider/images/2/29/Rise_of_the_Tomb_Raider.jpg/revision/latest?cb=20170210221117&path-prefix=pl", true, "Lara Croft Tomb Raider", new Guid("82642b42-06f4-43e5-847c-5433ce42b31b"), new DateTimeOffset(new DateTime(2018, 9, 12, 13, 20, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, -5, 0, 0, 0)) });

            migrationBuilder.CreateIndex(
                name: "IX_Games_PublisherId",
                table: "Games",
                column: "PublisherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}
