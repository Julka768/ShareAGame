using ShareAGame.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShareAGame.Repositories.Interfaces
{
    public interface IGameRepository
    {
        Task<IList<Game>> GetAllAsync();
        Guid Create(CreateNewGameDto dto);
        Guid CreatePublisher(CreateNewPublisherDto publishetDto);
        void Delete(Guid id);
        void Update(Guid id, CreateNewGameDto dto);
        Task<Game> GetById(Guid id);
    }

}
