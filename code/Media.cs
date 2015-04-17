using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Saga.Specification.Interfaces;

namespace Saga.Dal
{
    public class Media : IMedia, IEqualityComparer<Media>
    {
        public bool Equals(Media x, Media y)
        {
            throw new NotImplementedException();
        }

        public int GetHashCode(Media obj)
        {
            throw new NotImplementedException();
        }

        public string MediaFilePath
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int MediaId
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public Specification.Enumerations.MediaTypes MediaType
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public IList<ITag> Tags
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string Title
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool Equals(IMedia x, IMedia y)
        {
            throw new NotImplementedException();
        }

        public int GetHashCode(IMedia obj)
        {
            throw new NotImplementedException();
        }
    }
}
