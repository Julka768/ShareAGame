using Microsoft.AspNetCore.Mvc;
using ShareAGame.DataAccess.Models;
using ShareAGame.Repositories.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShareAGameAPI.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class GameController : ControllerBase
  {
    private readonly IGameRepository _gameRepository;

    public GameController(IGameRepository gameRepository)
    {
      _gameRepository = gameRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
      var games = await _gameRepository.GetAllAsync();
      return Ok(games);
    }
  }
}
