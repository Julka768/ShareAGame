using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ShareAGame.DataAccess;
using ShareAGame.DataAccess.Models;
using ShareAGame.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShareAGame.Repositories.Repositories
{
  public class GameRepository : IGameRepository
  {
    private readonly ShareAGameContext _dbContext;

    public GameRepository(ShareAGameContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<IList<Game>> GetAllAsync()
    {
      var games = await _dbContext.Games.OrderBy(g => g.Name).ToListAsync();
      return games;
    }

    public Guid Create(CreateNewGameDto gameDto)
    {
      var game = new Game()
      {
        Name = gameDto.Name,
        IsDigital = gameDto.IsDigital,
      };

      _dbContext.Games.Add(game);
      _dbContext.SaveChanges();

      return game.Id;

    }

  }
}
