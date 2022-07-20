using IONACodingExercise.ExternalDomains.BreedAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IONACodingExercise.Test.DataGenerators
{
    public  class CatDataGenerator
    {

        public List<CatBreedDTO> GetSimpleCatList()
        {
            List<CatBreedDTO> Cats = new List<CatBreedDTO>();
            Cats.Add(new CatBreedDTO() { name = "A Cat" });
            Cats.Add(new CatBreedDTO() { name = "B Cat" });
            Cats.Add(new CatBreedDTO() { name = "C Cat" });
            Cats.Add(new CatBreedDTO() { name = "D Cat" });
            Cats.Add(new CatBreedDTO() { name = "E Cat" });
            Cats.Add(new CatBreedDTO() { name = "F Cat" });
            Cats.Add(new CatBreedDTO() { name = "G Cat" });
            Cats.Add(new CatBreedDTO() { name = "H Cat" });
            Cats.Add(new CatBreedDTO() { name = "I Cat" });
            Cats.Add(new CatBreedDTO() { name = "J Cat" });
            Cats.Add(new CatBreedDTO() { name = "K Cat" });

            return Cats;
        }

        public List<CatBreedDTO> GetRandomCatList()
        {
            List<CatBreedDTO> Cats = new List<CatBreedDTO>();
            Cats.Add(new CatBreedDTO() { name = "Z Cat" });
            Cats.Add(new CatBreedDTO() { name = "C Cat" });
            Cats.Add(new CatBreedDTO() { name = "A Cat" });
            Cats.Add(new CatBreedDTO() { name = "Q Cat" });
            Cats.Add(new CatBreedDTO() { name = "R Cat" });
            Cats.Add(new CatBreedDTO() { name = "B Cat" });
            Cats.Add(new CatBreedDTO() { name = "D Cat" });
            Cats.Add(new CatBreedDTO() { name = "P Cat" });
            Cats.Add(new CatBreedDTO() { name = "S Cat" });
            Cats.Add(new CatBreedDTO() { name = "F Cat" });
            Cats.Add(new CatBreedDTO() { name = "I Cat" });
            Cats.Add(new CatBreedDTO() { name = "Y Cat" });

            return Cats;
        }

        public List<CatBreedDTO> GetCatList50()
        {
            List<CatBreedDTO> Cats = new List<CatBreedDTO>();
            Cats.Add(new CatBreedDTO() { name = "5 Cat" });
            Cats.Add(new CatBreedDTO() { name = "38 Cat" });
            Cats.Add(new CatBreedDTO() { name = "77 Cat" });
            Cats.Add(new CatBreedDTO() { name = "70 Cat" });
            Cats.Add(new CatBreedDTO() { name = "75 Cat" });
            Cats.Add(new CatBreedDTO() { name = "1 Cat" });
            Cats.Add(new CatBreedDTO() { name = "71 Cat" });
            Cats.Add(new CatBreedDTO() { name = "84 Cat" });
            Cats.Add(new CatBreedDTO() { name = "36 Cat" });
            Cats.Add(new CatBreedDTO() { name = "17 Cat" });
            Cats.Add(new CatBreedDTO() { name = "76 Cat" });
            Cats.Add(new CatBreedDTO() { name = "8 Cat" });
            Cats.Add(new CatBreedDTO() { name = "54 Cat" });
            Cats.Add(new CatBreedDTO() { name = "39 Cat" });
            Cats.Add(new CatBreedDTO() { name = "2 Cat" });
            Cats.Add(new CatBreedDTO() { name = "3 Cat" });
            Cats.Add(new CatBreedDTO() { name = "88 Cat" });
            Cats.Add(new CatBreedDTO() { name = "83 Cat" });
            Cats.Add(new CatBreedDTO() { name = "57 Cat" });
            Cats.Add(new CatBreedDTO() { name = "85 Cat" });
            Cats.Add(new CatBreedDTO() { name = "22 Cat" });
            Cats.Add(new CatBreedDTO() { name = "23 Cat" });
            Cats.Add(new CatBreedDTO() { name = "36 Cat" });
            Cats.Add(new CatBreedDTO() { name = "19 Cat" });
            Cats.Add(new CatBreedDTO() { name = "20 Cat" });
            Cats.Add(new CatBreedDTO() { name = "80 Cat" });
            Cats.Add(new CatBreedDTO() { name = "53 Cat" });
            Cats.Add(new CatBreedDTO() { name = "4 Cat" });
            Cats.Add(new CatBreedDTO() { name = "18 Cat" });
            Cats.Add(new CatBreedDTO() { name = "47 Cat" });
            Cats.Add(new CatBreedDTO() { name = "58 Cat" });
            Cats.Add(new CatBreedDTO() { name = "82 Cat" });
            Cats.Add(new CatBreedDTO() { name = "81 Cat" });
            Cats.Add(new CatBreedDTO() { name = "45 Cat" });
            Cats.Add(new CatBreedDTO() { name = "46 Cat" });
            Cats.Add(new CatBreedDTO() { name = "55 Cat" });
            Cats.Add(new CatBreedDTO() { name = "53 Cat" });
            Cats.Add(new CatBreedDTO() { name = "40 Cat" });
            Cats.Add(new CatBreedDTO() { name = "27 Cat" });
            Cats.Add(new CatBreedDTO() { name = "55 Cat" });
            Cats.Add(new CatBreedDTO() { name = "93 Cat" });
            Cats.Add(new CatBreedDTO() { name = "22 Cat" });
            Cats.Add(new CatBreedDTO() { name = "85 Cat" });
            Cats.Add(new CatBreedDTO() { name = "90 Cat" });
            Cats.Add(new CatBreedDTO() { name = "76 Cat" });
            Cats.Add(new CatBreedDTO() { name = "37 Cat" });
            Cats.Add(new CatBreedDTO() { name = "50 Cat" });
            Cats.Add(new CatBreedDTO() { name = "78 Cat" });
            Cats.Add(new CatBreedDTO() { name = "29 Cat" });
            Cats.Add(new CatBreedDTO() { name = "76 Cat" });

            return Cats;
        }


        public List<CatBreedDTO> GetEmptyCatList()
        {
            return new List<CatBreedDTO>();
        }
    }
}
