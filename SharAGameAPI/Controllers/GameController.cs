using Microsoft.AspNetCore.Mvc;
using ShareAGame.DataAccess.Models;
using ShareAGame.Repositories.Interfaces;
using System;
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

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll()
        {
            var games = await _gameRepository.GetAllAsync();
            return Ok(games);
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var game = await _gameRepository.GetById(id);
            return Ok(game);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateNewGame([FromBody] CreateNewGameDto dto)
        {
            var gameId = _gameRepository.Create(dto);

            return Created($"/api/game/{gameId}", null);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateNewPublisher([FromBody] CreateNewPublisherDto dto)
        {
            var publisherId = _gameRepository.CreatePublisher(dto);

            return Created($"/api/game/{publisherId}", null);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            _gameRepository.Delete(id);

            return NoContent();
        }

        [HttpPut("{id}")]
        public ActionResult Update([FromBody] EditGameDto dto, [FromRoute] Guid id)
        {

            _gameRepository.Update(id, dto);

            return Ok();
        }
    }
}
