using IONACodingExercise.ExternalDomains.BreedAgg;
using Newtonsoft.Json;
using RestSharp;

namespace IONACodingExercise.WebServices
{
    public class CatWebService
    {
        RestClient client;
        readonly string API_KEY= "bb16bac4-8615-4273-9f91-01f713be074a";
        public CatWebService()
        {
            client = new RestClient("https://api.thecatapi.com");
            client.AddDefaultHeader("x-api-key", API_KEY);
        }

        public List<CatBreedDTO> GetCatBreeds(int limit, int page)
        {
            RestRequest request = new RestRequest("v1/breeds");
            request.AddParameter("limit", limit);
            request.AddParameter("page", page);

            var result = client.ExecuteGet(request);

            if (result.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<List<CatBreedDTO>>(result.Content);
            }
            return null;
        }

        public List<BreedImageDTO> GetCatBreedImages(int limit, int page)
        {
            RestRequest request = new RestRequest("v1/images/search");
            request.AddParameter("limit", limit);
            request.AddParameter("page", page);

            var result = client.ExecuteGet(request);

            if (result.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<List<BreedImageDTO>>(result.Content);
            }
            return null;
        }

        public BreedImageDTO GetCatBreedImage(string ImageId)
        {
            RestRequest request = new RestRequest($"v1/images/{ImageId}");

            var result = client.ExecuteGet(request);

            if (result.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<BreedImageDTO>(result.Content);
            }
            return null;
        }
    }
}
