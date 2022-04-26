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
      builder.HasData(
        new Game()
        {
          Id = Guid.NewGuid(),
          Name = "Lara Croft Tomb Raider",
          IsDigital = true,
        },
        new Game()
        {
          Id = Guid.NewGuid(),
          Name = "Assasin Creed Valhalla",
          IsDigital = true,
        },
        new Game()
        {
          Id = Guid.NewGuid(),
          Name = "Watch Dogs",
          IsDigital = false,
        });

    }
  }
}
