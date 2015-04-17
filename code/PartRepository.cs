using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saga.Specification.Interfaces.Artists;
using Saga.Specifications.Interfaces.Parts;

namespace Saga.Dal
{
    public class PartRepository : IPartRepository
    {
        public PartRepository (IArtistRepository atristRepo)
        {

        }

        public IList<Specification.Interfaces.IPartBase> GetAll()
        {
            throw new NotImplementedException();
        }

        public Specification.Interfaces.IPartBase GetById(int partId)
        {
            throw new NotImplementedException();
        }

        public IList<Specification.Interfaces.IPartBase> GetByName(string keyword)
        {
            throw new NotImplementedException();
        }

        public IList<Specification.Interfaces.Musical.IPart> GetKnownPartsForTheTrack(Specification.Interfaces.Audio.ITrack track)
        {
            throw new NotImplementedException();
        }
    }
}
