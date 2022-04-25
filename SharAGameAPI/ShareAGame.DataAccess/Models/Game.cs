using System;

namespace ShareAGame.DataAccess.Models
{
  public class Game
  {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool IsDigital { get; set; }
  }
}
