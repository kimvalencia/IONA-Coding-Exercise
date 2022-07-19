using IONACodingExercise.ExternalDomains.BreedAgg;

namespace IONACodingExercise.WebServices
{
    public interface ICatWebService
    {
        List<CatBreedDTO> GetCatBreeds(int limit, int page);
        List<BreedImageDTO> GetCatBreedImages(int limit, int page);
        BreedImageDTO GetCatBreedImage(string ImageId);
    }
}
