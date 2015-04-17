using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saga.Specification.Interfaces.Audio;

namespace Saga.Dal
{
    public class AlbumRepository : IAlbumRepository
    {
        public IAlbum Get(int albumId)
        {
            throw new NotImplementedException();
        }

        public IAlbum Get()
        {
            throw new NotImplementedException();
        }

        public void Save(IAlbum album)
        {
            throw new NotImplementedException();
        }
    }
}
