using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareAGame.DataAccess.Models
{
  public class CreateNewGameDto
  {
    public string Name { get; set; }
    public bool IsDigital { get; set; }
  }
}
