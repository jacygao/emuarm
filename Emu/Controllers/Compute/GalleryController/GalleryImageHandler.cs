using GalleryController;

namespace Emu.Controllers.Compute.GalleryController
{
    public class GalleryImageHandler : IGalleryImagesController
    {
        public Task<GalleryImage> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string galleryName, string galleryImageName, string api_version, GalleryImage galleryImage)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string subscriptionId, string resourceGroupName, string galleryName, string galleryImageName, string api_version)
        {
            throw new NotImplementedException();
        }

        public Task<GalleryImage> GetAsync(string subscriptionId, string resourceGroupName, string galleryName, string galleryImageName, string api_version)
        {
            throw new NotImplementedException();
        }

        public Task<GalleryImageList> ListByGalleryAsync(string subscriptionId, string resourceGroupName, string galleryName, string api_version)
        {
            throw new NotImplementedException();
        }

        public Task<GalleryImage> UpdateAsync(string subscriptionId, string resourceGroupName, string galleryName, string galleryImageName, string api_version, GalleryImageUpdate galleryImage)
        {
            throw new NotImplementedException();
        }
    }
}