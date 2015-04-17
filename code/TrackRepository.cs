using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saga.Specification.Interfaces.Audio;
using Saga.Specification.Interfaces.Genres;
using Saga.Specifications.Interfaces.Parts;

namespace Saga.Dal
{
    public class TrackRepository : ITrackRepository
    {
        public TrackRepository(IGenreRepository genreRepo, IAlbumRepository albumRepo, IPartRepository partRepo)
        {

        }

        public void Delete(ITrack task)
        {
            throw new NotImplementedException();
        }

        public void Genre_Add(ITrack track, Specification.Interfaces.Genres.IGenre genre)
        {
            throw new NotImplementedException();
        }

        public void Genre_Remove(ITrack track, Specification.Interfaces.Genres.IGenre genre)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITrack> GetAll()
        {
            throw new NotImplementedException();
        }

        public ITrack GetByFilePath(string trackFilePath)
        {
            throw new NotImplementedException();
        }

        public ITrack GetById(int taskId)
        {
            throw new NotImplementedException();
        }

        public ITrack GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public IList<ITrack> GetFromAlbum(IAlbum album)
        {
            throw new NotImplementedException();
        }

        public void PerformanceAdd(ITrack track, Specification.Interfaces.Artists.IArtist artist, Specification.Interfaces.IPartBase part)
        {
            throw new NotImplementedException();
        }

        public void Save(ITrack task)
        {
            throw new NotImplementedException();
        }
    }
}
