using IONACodingExercise.ExternalDomains.BreedAgg;
using IONACodingExercise.Test.DataGenerators;
using IONACodingExercise.WebServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IONACodingExercise.Test.Services
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
            return new CatDataGenerator().GetCatList50().OrderBy(q => q.name).Skip((page-1) * limit).Take(limit).ToList();
        }
    }
}
