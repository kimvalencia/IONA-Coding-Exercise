using IONACodingExercise.ExternalDomains.BreedAgg;
using Newtonsoft.Json;
using RestSharp;

namespace IONACodingExercise.WebServices
{
    public class DogWebService
    {
        RestClient client;
        readonly string API_KEY = "d60209ef-c9da-42a2-9146-794fa3861299";
        public DogWebService()
        {
            client = new RestClient("https://api.thedogapi.com");
            client.AddDefaultHeader("x-api-key", API_KEY);
        }

        public List<DogBreedDTO> GetDogBreeds(int limit, int page)
        {
            RestRequest request = new RestRequest("v1/breeds");
            request.AddParameter("limit", limit);
            request.AddParameter("page", page);

            var result = client.ExecuteGet(request);

            if (result.IsSuccessful)
            {
                return JsonConvert.DeserializeObject<List<DogBreedDTO>>(result.Content);
            }
            return null;
        }
    }
}
