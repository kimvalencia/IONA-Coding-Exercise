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

        public List<DogBreedDTO> GetRandomDogList()
        {
            List<DogBreedDTO> Dogs = new List<DogBreedDTO>();

            Dogs.Add(new DogBreedDTO() { name = "H Dog" });
            Dogs.Add(new DogBreedDTO() { name = "W Dog" });
            Dogs.Add(new DogBreedDTO() { name = "Y Dog" });
            Dogs.Add(new DogBreedDTO() { name = "F Dog" });
            Dogs.Add(new DogBreedDTO() { name = "C Dog" });
            Dogs.Add(new DogBreedDTO() { name = "K Dog" });
            Dogs.Add(new DogBreedDTO() { name = "L Dog" });
            Dogs.Add(new DogBreedDTO() { name = "P Dog" });
            Dogs.Add(new DogBreedDTO() { name = "Q Dog" });
            Dogs.Add(new DogBreedDTO() { name = "X Dog" });
            Dogs.Add(new DogBreedDTO() { name = "T Dog" });
            Dogs.Add(new DogBreedDTO() { name = "S Dog" });
            Dogs.Add(new DogBreedDTO() { name = "M Dog" });


            return Dogs;
        }

        public List<DogBreedDTO> GetDogList50()
        {
            List<DogBreedDTO> Dogs = new List<DogBreedDTO>();

            Dogs.Add(new DogBreedDTO() { name = "84 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "68 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "95 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "35 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "75 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "20 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "82 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "17 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "94 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "94 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "65 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "54 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "56 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "3 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "97 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "94 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "71 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "75 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "58 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "100 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "2 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "15 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "17 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "93 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "36 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "86 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "6 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "23 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "7 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "90 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "99 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "15 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "2 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "1 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "74 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "78 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "50 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "59 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "76 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "34 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "99 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "20 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "62 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "51 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "30 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "92 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "33 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "16 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "68 Dog" });
            Dogs.Add(new DogBreedDTO() { name = "71 Dog" });

            return Dogs;
        }

        public List<DogBreedDTO> GetEmptyDogList()
        {
            return new List<DogBreedDTO>();
        }
    }
}
