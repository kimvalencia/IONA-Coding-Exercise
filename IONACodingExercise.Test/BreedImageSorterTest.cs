using IONACodingExercise.BLL;
using IONACodingExercise.Test.DataGenerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IONACodingExercise.Test
{
    [TestClass]
    public class BreedImageSorterTest
    {
        [TestMethod]
        public void CombineDogAndCatImages_Simple_1stElementCat()
        {
            var CatImages = new BreedImageGenerator().GetCatBreedImages();
            var DogImages = new BreedImageGenerator().GetDogBreedImages();
            var result = new BreedSorter().CombineDogAndCatBreedImages(CatImages, DogImages, 10, 1);
            Assert.AreEqual("A Cat", result[0].id);
        }

        [TestMethod]
        public void CombineDogAndCatImages_Simple_Count10()
        {
            var CatImages = new BreedImageGenerator().GetCatBreedImages();
            var DogImages = new BreedImageGenerator().GetDogBreedImages();
            var result = new BreedSorter().CombineDogAndCatBreedImages(CatImages, DogImages, 10, 1);
            Assert.AreEqual(10, result.Count);
        }
    }
}
