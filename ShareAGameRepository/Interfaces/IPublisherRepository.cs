using ShareAGame.DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShareAGame.Repositories.Repositories
{
    public interface IPublisherRepository
    {
        Task<IList<SelectOption>> GetAllSelectOptions();
    }
}