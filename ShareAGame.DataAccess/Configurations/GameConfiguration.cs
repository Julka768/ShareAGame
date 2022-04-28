using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShareAGame.DataAccess.Models;
using System;

namespace ShareAGame.DataAccess.Configurations
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasOne(g => g.Publisher)
                .WithMany(p => p.Games)
                .HasForeignKey(g => g.PublisherId)
                .OnDelete(DeleteBehavior.NoAction)
                .HasConstraintName("FK_dbo.game.Publisher_PublisherId");

            builder.HasData(
              new Game()
              {
                  Id = Guid.NewGuid(),
                  Name = "Lara Croft Tomb Raider",
                  IsDigital = true,
                  PublisherId = new Guid("82642b42-06f4-43e5-847c-5433ce42b31b"),
                  ImageUrl = "https://static.wikia.nocookie.net/tombraider/images/2/29/Rise_of_the_Tomb_Raider.jpg/revision/latest?cb=20170210221117&path-prefix=pl",
                  GamePlatform = Entities.GamePlatform.NintendoSwitch,
                  ReleaseDate = DateTimeOffset.Parse("2018-09-12T13:20:00.000-05:00")
              },
              new Game()
              {
                  Id = Guid.NewGuid(),
                  Name = "Assasin Creed Valhalla",
                  IsDigital = true,
                  PublisherId = new Guid("7c7bc643-b767-4614-8724-fe96ecc57eb2"),
                  ImageUrl = "https://cdn1.epicgames.com/400347196e674de89c23cc2a7f2121db/offer/AC%20KINGDOM%20PREORDER_STANDARD%20EDITION_EPIC_Key_Art_Portrait_640x854-640x854-288120c5573756cb988b6c1968cebd86.png",
                  GamePlatform = Entities.GamePlatform.Pc,
                  ReleaseDate = DateTimeOffset.Parse("2020-11-10T13:20:00.000-05:00")
              },
              new Game()
              {
                  Id = Guid.NewGuid(),
                  Name = "Watch Dogs",
                  IsDigital = false,
                  PublisherId = new Guid("7c7bc643-b767-4614-8724-fe96ecc57eb2"),
                  ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTaaud_5UmER7n84qaagoWadSzdUnahTfDRNw&usqp=CAU",
                  GamePlatform = Entities.GamePlatform.Ps4,
                  ReleaseDate = DateTimeOffset.Parse("2014-05-26T13:20:00.000-05:00")
              });

        }
    }
}
