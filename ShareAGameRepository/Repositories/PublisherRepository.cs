using Microsoft.EntityFrameworkCore;
using ShareAGame.DataAccess;
using ShareAGame.DataAccess.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShareAGame.Repositories.Repositories
{
    public class PublisherRepository : IPublisherRepository
    {
        private readonly ShareAGameContext _dbContext;

        public PublisherRepository(ShareAGameContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IList<SelectOption>> GetAllSelectOptions()
        {
            var publisher = await _dbContext.Publishers.OrderBy(s => s.Name)
                .Select(s => new SelectOption()
                {
                    Id = s.Id,
                    Name = s.Name,
                })
                .ToListAsync();

            return publisher;
        }
    }
}
