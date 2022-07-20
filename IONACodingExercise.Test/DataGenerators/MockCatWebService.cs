using IONACodingExercise.ExternalDomains.BreedAgg;
using IONACodingExercise.WebServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IONACodingExercise.Test.DataGenerators
{
    public class MockCatWebService : ICatWebService
    {
        public BreedImageDTO GetCatBreedImage(string ImageId)
        {
            throw new NotImplementedException();
        }

        public List<BreedImageDTO> GetCatBreedImages(int limit, int page)
        {
            throw new NotImplementedException();
        }

        public List<CatBreedDTO> GetCatBreeds(int limit, int page)
        {
            throw new NotImplementedException();
        }
    }
}
