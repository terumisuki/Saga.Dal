using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saga.Specification.Interfaces.Artists;

namespace Saga.Dal
{
    public class ArtistRepository : IArtistRepository 
    {
        public IList<IArtist> GetAll()
        {
            throw new NotImplementedException();
        }

        public IArtist GetById(int artistId)
        {
            throw new NotImplementedException();
        }

        public IList<IArtist> GetByName(string keyword)
        {
            throw new NotImplementedException();
        }

        public IList<Specification.Interfaces.Musical.IOpus> GetKnownOpuses(int artistId)
        {
            throw new NotImplementedException();
        }

        public IList<Specification.Interfaces.Musical.IMovement> GetMovements(int pieceId)
        {
            throw new NotImplementedException();
        }

        public IList<Specification.Interfaces.Musical.IPart> GetParts(int movementId)
        {
            throw new NotImplementedException();
        }

        public IList<Specification.Interfaces.Musical.IPiece> GetPieces(int opusId)
        {
            throw new NotImplementedException();
        }

        public int Save(IArtist artist)
        {
            throw new NotImplementedException();
        }

        public IList<IArtist> Search(string artistName)
        {
            throw new NotImplementedException();
        }
    }
}
