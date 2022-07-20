using IONACodingExercise.BLL;
using IONACodingExercise.Domain.BreedAgg;
using IONACodingExercise.ExternalDomains.BreedAgg;
using IONACodingExercise.WebServices;
using Mapster;

namespace IONACodingExercise.Services
{
    public class BreedService
    {
        ICatWebService _catWebService;
        IDogWebService _dogWebService;

        public BreedService(ICatWebService catWebService, IDogWebService dogWebService)
        {
            _catWebService = catWebService;
            _dogWebService = dogWebService;
        }

        public List<Breed> GetCombinedBreeds(int limit, int page)
        {
            List<CatBreedDTO> CatBreeds =  _catWebService.GetCatBreeds(limit*page, 1);
            List<DogBreedDTO> DogBreeds =  _dogWebService.GetDogBreeds(limit*page, 1);

            List<Breed> breeds = new BreedSorter().CombineDogAndCatBreeds(CatBreeds, DogBreeds, limit,page);

            return breeds;
        }

        public List<BreedImage> GetBreedImagesByBreed(string breed, int limit, int page)
        {
            List<BreedImage> BreedImages = new List<BreedImage>();

            if (breed.ToLower().Trim().Equals("cat"))
            {
                List<BreedImageDTO> CatBreedImages = _catWebService.GetCatBreedImages(limit, page);
                if (CatBreedImages != null)
                    BreedImages = CatBreedImages.Adapt<List<BreedImage>>();
            }
            else if (breed.ToLower().Trim().Equals("dog"))
            {
                List<BreedImageDTO> DogBreedImages = _dogWebService.GetDogBreedImages(limit, page);

                if (DogBreedImages != null)
                    BreedImages = DogBreedImages.Adapt<List<BreedImage>>();
            }

            return BreedImages;
        }

        public List<BreedImage> GetCombinedBreedImages(int limit, int page)
        {
            List<BreedImageDTO> CatBreedImages = _catWebService.GetCatBreedImages(limit * page, 1);
            List<BreedImageDTO> DogBreedImages = _dogWebService.GetDogBreedImages(limit * page, 1);

            List<BreedImage> BreedImages = new BreedSorter().CombineDogAndCatBreedImages(CatBreedImages, DogBreedImages, limit, page);

            return BreedImages;
        }

        public BreedImage GetBreedImageById(string ImageId)
        {
            BreedImage breedImage = null;
            
            BreedImageDTO breedImageDTO = null;

            breedImageDTO = _catWebService.GetCatBreedImage(ImageId);

            if(breedImageDTO==null)
                breedImageDTO = _dogWebService.GetDogBreedImage(ImageId);

            if (breedImageDTO != null)
            {
                breedImage = breedImageDTO.Adapt<BreedImage>();
            }

            return breedImage;
        }
    }
}
