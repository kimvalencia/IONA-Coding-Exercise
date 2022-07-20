using IONACodingExercise.BLL;
using IONACodingExercise.Domain.BreedAgg;
using IONACodingExercise.Test.DataGenerators;

namespace IONACodingExercise.Test
{
    [TestClass]
    public class BreedSorterTest
    {
        [TestMethod]
        public void CombineDogAndCatBreeds_Simple_1stElementCat()
        {
            var dogs = new DogDataGenerator().GetSimpleDogList();
            var cats = new CatDataGenerator().GetSimpleCatList();

            var result = new BreedSorter().CombineDogAndCatBreeds(cats, dogs, 10, 1);

            Assert.AreEqual("A Cat", result[0].name);
        }

        [TestMethod]
        public void CombineDogAndCatBreeds_Simple_10Result()
        {
            var dogs = new DogDataGenerator().GetSimpleDogList();
            var cats = new CatDataGenerator().GetSimpleCatList();

            var result = new BreedSorter().CombineDogAndCatBreeds(cats, dogs, 10, 1);

            Assert.AreEqual(10, result.Count);
        }

        [TestMethod]
        public void CombineDogAndCatBreeds_Simple_5Dog5Cats()
        {
            var dogs = new DogDataGenerator().GetSimpleDogList();
            var cats = new CatDataGenerator().GetSimpleCatList();

            var result = new BreedSorter().CombineDogAndCatBreeds(cats, dogs, 10, 1);
            
            //Dog Count
            Assert.AreEqual(5, result.Where(q=>q.name.ToLower().Contains("dog")).ToList().Count);
            //Cat Count
            Assert.AreEqual(5, result.Where(q=>q.name.ToLower().Contains("cat")).ToList().Count);
        }

        [TestMethod]
        public void CombineDogAndCatBreeds_EmptyDog_10Cats()
        {
            var dogs = new DogDataGenerator().GetEmptyDogList();
            var cats = new CatDataGenerator().GetSimpleCatList();

            var result = new BreedSorter().CombineDogAndCatBreeds(cats, dogs, 10, 1);

            //Cat Count
            Assert.AreEqual(10, result.Where(q => q.name.ToLower().Contains("cat")).ToList().Count);
        }

        [TestMethod]
        public void CombineDogAndCatBreeds_EmptyCat_10Dogs()
        {
            var dogs = new DogDataGenerator().GetSimpleDogList();
            var cats = new CatDataGenerator().GetEmptyCatList();

            var result = new BreedSorter().CombineDogAndCatBreeds(cats, dogs, 10, 1);

            //Dog Count
            Assert.AreEqual(10, result.Where(q => q.name.ToLower().Contains("dog")).ToList().Count);
        }

        [TestMethod]
        public void CombineDogAndCatBreeds_Random_1stElementCat()
        {
            var dogs = new DogDataGenerator().GetRandomDogList();
            var cats = new CatDataGenerator().GetRandomCatList();

            var result = new BreedSorter().CombineDogAndCatBreeds(cats, dogs, 10, 1);

            Assert.AreEqual("A Cat", result[0].name);
        }

        [TestMethod]
        public void CombineDogAndCatBreeds_Random_10Result()
        {
            var dogs = new DogDataGenerator().GetRandomDogList();
            var cats = new CatDataGenerator().GetRandomCatList();

            var result = new BreedSorter().CombineDogAndCatBreeds(cats, dogs, 10, 1);

            Assert.AreEqual(10, result.Count);
        }
    }
}