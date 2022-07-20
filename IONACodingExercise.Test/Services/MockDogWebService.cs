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
    public class MockDogWebService : IDogWebService
    {
        public BreedImageDTO GetDogBreedImage(string ImageId)
        {
            throw new NotImplementedException();
        }

        public List<BreedImageDTO> GetDogBreedImages(int limit, int page)
        {
            throw new NotImplementedException();
        }

        public List<DogBreedDTO> GetDogBreeds(int limit, int page)
        {
            return new DogDataGenerator().GetDogList50().OrderBy(q=>q.name).Skip((page-1) * limit).Take(limit).ToList();
        }
    }
}
