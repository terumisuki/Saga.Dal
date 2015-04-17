using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Saga.Specification;
using Saga.Specification.Interfaces.Images;

namespace Saga.Dal
{
    public class Image : Media, IImage
    {
        public string ArchiveFilePath { get; set; }

        public Image()
        {
            this.MediaType = Enumerations.MediaTypes.Image;
        }

    }
}
