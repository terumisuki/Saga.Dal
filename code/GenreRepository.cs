using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saga.Specification.Interfaces.Genres;

namespace Saga.Dal
{
    public class GenreRepository : IGenreRepository
    {
        public IList<IGenre> Get(Specification.Interfaces.Audio.ITrack track)
        {
            throw new NotImplementedException();
        }

        public IList<IGenre> GetAll()
        {
            throw new NotImplementedException();
        }

        public IGenre GetById(int genreId)
        {
            throw new NotImplementedException();
        }

        public IList<IGenre> GetByName(string keyword)
        {
            throw new NotImplementedException();
        }
    }
}
