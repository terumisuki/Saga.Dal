using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saga.Specification.Interfaces.Images;
using Saga.Specification.Interfaces.PhotoAlbums;

namespace Saga.Dal
{
    public class PhotoAlbumRepository : IPhotoAlbumRepository 
    {
        public PhotoAlbumRepository(IImageBusiness imageBusiness)
        {

        }

        public void Delete(int albumId)
        {
            throw new NotImplementedException();
        }

        public List<IPhotoAlbum> GetAll()
        {
            throw new NotImplementedException();
        }

        public IPhoto GetNextPhoto(string albumCode, int userId)
        {
            throw new NotImplementedException();
        }

        public List<IPhoto> GetPhotos(int albumId)
        {
            throw new NotImplementedException();
        }

        public void RemovePhoto(int albumId, int photoId)
        {
            throw new NotImplementedException();
        }

        public int Save(IPhotoAlbum album)
        {
            throw new NotImplementedException();
        }

        public void ShowPhotoOnAlbum(int albumId, int photoId, string english, string japanese)
        {
            throw new NotImplementedException();
        }
    }
}
