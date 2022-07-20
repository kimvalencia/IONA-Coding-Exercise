using IONACodingExercise.Domain.BreedAgg;
using IONACodingExercise.ExternalDomains.BreedAgg;
using Mapster;

namespace IONACodingExercise.BLL
{
    public class BreedSorter
    {

        public List<Breed> CombineDogAndCatBreeds(List<CatBreedDTO> CatBreeds, List<DogBreedDTO> DogBreeds, int limit, int page)
        {
            List<Breed> breeds = new List<Breed>();

            if (CatBreeds != null)
                breeds.AddRange(CatBreeds.Adapt<List<Breed>>());

            if (DogBreeds != null)
                breeds.AddRange(DogBreeds.Adapt<List<Breed>>());

            breeds = breeds.OrderBy(q => q.name).Skip((page - 1) * limit ).Take(limit).ToList();

            return breeds;
        }

        public List<BreedImage> CombineDogAndCatBreedImages(List<BreedImageDTO> CatBreedImages, List<BreedImageDTO> DogBreedImages, int limit, int page)
        {
            List<BreedImage> BreedImages = new List<BreedImage>();
            if (CatBreedImages != null)
                BreedImages.AddRange(CatBreedImages.Adapt<List<BreedImage>>());

            if (DogBreedImages != null)
                BreedImages.AddRange(DogBreedImages.Adapt<List<BreedImage>>());

            BreedImages = BreedImages.OrderBy(q => q.id).Skip((page - 1) * limit).Take(limit).ToList();

            return BreedImages;
        }
    }
}
