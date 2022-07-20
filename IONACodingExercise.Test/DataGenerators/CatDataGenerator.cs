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

        public List<CatBreedDTO> GetEmptyCatList()
        {
            return new List<CatBreedDTO>();
        }
    }
}
