using IONACodingExercise.Services;
using IONACodingExercise.Test.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IONACodingExercise.Test
{
    [TestClass]
    public class BreedServiceTest
    {
        [TestMethod]
        public void GetCombinedBreeds_Page1Limit10_Return10()
        {
           var service = new BreedService(new MockCatWebService(), new MockDogWebService());
            var result = service.GetCombinedBreeds(10, 1);

            Assert.AreEqual(10, result.Count);

        }

        [TestMethod]
        public void GetCombinedBreeds_Page1Limit10_1stElementCat()
        {
            var service = new BreedService(new MockCatWebService(), new MockDogWebService());
            var result = service.GetCombinedBreeds(10, 1);

            Assert.AreEqual("1 Cat", result[0].name);
        }

        [TestMethod]
        public void GetCombinedBreeds_Page2Limit10_1stElement19Cat()
        {
            var service = new BreedService(new MockCatWebService(), new MockDogWebService());
            var result = service.GetCombinedBreeds(10, 2);

            Assert.AreEqual("19 Cat", result[0].name);
        }
    }
}
