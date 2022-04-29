using Microsoft.AspNetCore.Mvc;
using ShareAGame.Repositories.Repositories;
using System.Threading.Tasks;

namespace ShareAGameAPI.Controllers

{
    [ApiController]
    [Route("[controller]")]
    public class PublisherController : ControllerBase
    {
        private readonly IPublisherRepository _publisherRepository;
        public PublisherController(IPublisherRepository publisherRepository)
        {
            _publisherRepository = publisherRepository;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllSelectOptions()
        {
            var publisher = await _publisherRepository.GetAllSelectOptions();
            return Ok(publisher);
        }
    }
}
