using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Saga.Specification.Interfaces.PhotoAlbums;

namespace Saga.Dal
{
    public class Photo : Image, IPhoto
    {
        public string EnglishCaption { get; set; }
        public string JapaneseCaption { get; set; }
    }
}
