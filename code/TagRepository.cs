using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saga.Specification.Interfaces.Tags;

namespace Saga.Dal
{
    public class TagRepository : ITagRepository
    {
        public IList<Specification.Interfaces.ITag> GetActiveTags()
        {
            throw new NotImplementedException();
        }

        public IList<Specification.Interfaces.ITag> GetAll()
        {
            throw new NotImplementedException();
        }

        public Specification.Interfaces.ITag GetById(int tagId)
        {
            throw new NotImplementedException();
        }

        public IEqualityComparer<Specification.Interfaces.ITag> GetComparer()
        {
            throw new NotImplementedException();
        }

        public IList<Specification.Interfaces.ITag> Search(string keyword)
        {
            throw new NotImplementedException();
        }
    }
}
