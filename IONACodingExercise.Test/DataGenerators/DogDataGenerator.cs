using IONACodingExercise.ExternalDomains.BreedAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IONACodingExercise.Test.DataGenerators
{
    public class DogDataGenerator
    {
        public List<DogBreedDTO> GetSimpleDogList()
        {
            List<DogBreedDTO> Dogs = new List<DogBreedDTO>();

            Dogs.Add(new DogBreedDTO() { name = "A Dog" });
            Dogs.Add(new DogBreedDTO() { name = "B Dog" });
            Dogs.Add(new DogBreedDTO() { name = "C Dog" });
            Dogs.Add(new DogBreedDTO() { name = "D Dog" });
            Dogs.Add(new DogBreedDTO() { name = "E Dog" });
            Dogs.Add(new DogBreedDTO() { name = "F Dog" });
            Dogs.Add(new DogBreedDTO() { name = "G Dog" });
            Dogs.Add(new DogBreedDTO() { name = "H Dog" });
            Dogs.Add(new DogBreedDTO() { name = "I Dog" });
            Dogs.Add(new DogBreedDTO() { name = "J Dog" });

            return Dogs;
        }

        public List<DogBreedDTO> GetEmptyDogList()
        {
            return new List<DogBreedDTO>();
        }
    }
}
