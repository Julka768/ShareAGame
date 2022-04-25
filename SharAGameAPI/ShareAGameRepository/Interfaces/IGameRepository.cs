using ShareAGame.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareAGame.Repositories.Interfaces
{
  public interface IGameRepository
    {
      Task<IList<Game>> GetAllAsync();
      Guid Create(CreateNewGameDto dto);
  }
  
}
