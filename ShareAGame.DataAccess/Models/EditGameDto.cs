using ShareAGame.DataAccess.Entities;
using System;

namespace ShareAGame.DataAccess.Models
{
    public class EditGameDto
    {
        public string Name { get; set; }
        public bool IsDigital { get; set; }
        public DateTimeOffset ReleaseDate { get; set; }
        public string ImageUrl { get; set; }
        public Guid PublisherId { get; set; }
        public GamePlatform GamePlatform { get; set; }
    }
}
