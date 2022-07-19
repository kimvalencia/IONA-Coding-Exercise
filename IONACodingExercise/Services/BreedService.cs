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
            List<Breed> breeds = new List<Breed>();
            
            List<CatBreedDTO> CatBreeds =  _catWebService.GetCatBreeds(limit*page, 1);
            List<DogBreedDTO> DogBreeds =  _dogWebService.GetDogBreeds(limit*page, 1);

            if (CatBreeds != null)
                breeds.AddRange(CatBreeds.Adapt<List<Breed>>());

            if (DogBreeds != null)
                breeds.AddRange(DogBreeds.Adapt<List<Breed>>());

            breeds = breeds.OrderBy(q => q.name).Skip(page - 1).Take(limit).ToList();

            return breeds;
        }

        public List<BreedImage> GetBreedImagesByBreed(string breed, int limit, int page)
        {
            List<BreedImage> BreedImages = new List<BreedImage>();

            if (breed.ToLower().Trim().Equals("cat"))
            {
                List<BreedImageDTO> CatBreedImages = _catWebService.GetCatBreedImages(limit * page, 1);
                if (CatBreedImages != null)
                    BreedImages = CatBreedImages.Adapt<List<BreedImage>>();
            }
            else if (breed.ToLower().Trim().Equals("dog"))
            {
                List<BreedImageDTO> DogBreedImages = _dogWebService.GetDogBreedImages(limit * page, 1);

                if (DogBreedImages != null)
                    BreedImages = DogBreedImages.Adapt<List<BreedImage>>();
            }

            return BreedImages;
        }

        public List<BreedImage> GetCombinedBreedImages(int limit, int page)
        {
            List<BreedImage> BreedImages = new List<BreedImage>();

            List<BreedImageDTO> CatBreedImages = _catWebService.GetCatBreedImages(limit * page, 1);
            List<BreedImageDTO> DogBreedImages = _dogWebService.GetDogBreedImages(limit * page, 1);

            if (CatBreedImages != null)
                BreedImages.AddRange(CatBreedImages.Adapt<List<BreedImage>>());

            if (DogBreedImages != null)
                BreedImages.AddRange(DogBreedImages.Adapt<List<BreedImage>>());

            BreedImages = BreedImages.OrderBy(q => q.id).Skip(page - 1).Take(limit).ToList();

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
