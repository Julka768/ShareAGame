using ShareAGame.DataAccess.Entities;
using System;

namespace ShareAGame.DataAccess.Models
{
  public class CreateNewGameDto
  {
        public string Name { get; set; }
        public bool IsDigital { get; set; }
        public DateTimeOffset ReleaseDate { get; set; }
        public string ImageUrl { get; set; }
        public virtual Publisher Publisher { get; set; }
        public GamePlatform GamePlatform { get; set; }
    }
}
