using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShareAGame.DataAccess.Models;
using ShareAGame.Repositories.Interfaces;
using Swashbuckle.AspNetCore.Annotations;
using System;
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

    [HttpPost]
    public async Task<IActionResult> CreateNewGame([FromBody] CreateNewGameDto dto)
    {
      var gameId = _gameRepository.Create(dto);

      return Created($"/api/game/{gameId}", null);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete([FromRoute] Guid id)
    {
      _gameRepository.Delete(id);

      return NoContent();
    }

    [HttpPut("{id}")]
    public ActionResult Update([FromBody] CreateNewGameDto dto, [FromRoute] Guid id)
    {

      _gameRepository.Update(id, dto);

      return Ok();
    }
  }
}