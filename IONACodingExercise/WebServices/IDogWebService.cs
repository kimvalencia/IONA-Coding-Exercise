using IONACodingExercise.ExternalDomains.BreedAgg;

namespace IONACodingExercise.WebServices
{
    public interface IDogWebService
    {
        List<DogBreedDTO> GetDogBreeds(int limit, int page);
        List<BreedImageDTO> GetDogBreedImages(int limit, int page);
        BreedImageDTO GetDogBreedImage(string ImageId);
    }
}
