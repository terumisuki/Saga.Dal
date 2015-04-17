using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saga.Specification.Interfaces.Images;

namespace Saga.Dal
{
    public class ImageRepository : IImageRepository 
    {
        public void ClearNoRepeatList(int userid)
        {
            throw new NotImplementedException();
        }

        public IImage Get(int id)
        {
            throw new NotImplementedException();
        }

        public IImage Get(IImage image)
        {
            throw new NotImplementedException();
        }

        public IList<IImage> GetImagesForSlideShow(int userid)
        {
            throw new NotImplementedException();
        }

        public IList<IImage> GetImagesForSlideShow(int userId, IList<Specification.Interfaces.ITag> includedTags, IList<Specification.Interfaces.ITag> excludedTags)
        {
            throw new NotImplementedException();
        }

        public IList<IImage> GetRandomPhotoFromPhotoAlbum(int userid, string albumCode)
        {
            throw new NotImplementedException();
        }

        public IImage Save(IImage image)
        {
            throw new NotImplementedException();
        }

        public void TagAdd(IImage image, Specification.Interfaces.ITag tag)
        {
            throw new NotImplementedException();
        }

        public void TagRemove(IImage image, Specification.Interfaces.ITag tag)
        {
            throw new NotImplementedException();
        }
    }
}
