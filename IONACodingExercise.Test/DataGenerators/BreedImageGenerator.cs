using IONACodingExercise.ExternalDomains.BreedAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IONACodingExercise.Test.DataGenerators
{
    public class BreedImageGenerator
    {
        public List<BreedImageDTO> GetCatBreedImages()
        {
            List<BreedImageDTO> CatImages = new List<BreedImageDTO>();
            CatImages.Add(new BreedImageDTO() { id = "A Cat" });
            CatImages.Add(new BreedImageDTO() { id = "B Cat" });
            CatImages.Add(new BreedImageDTO() { id = "C Cat" });
            CatImages.Add(new BreedImageDTO() { id = "D Cat" });
            CatImages.Add(new BreedImageDTO() { id = "E Cat" });

            return CatImages;
        }

        public List<BreedImageDTO> GetDogBreedImages()
        {
            List<BreedImageDTO> DogImages = new List<BreedImageDTO>();
            DogImages.Add(new BreedImageDTO() { id = "A Dog" });
            DogImages.Add(new BreedImageDTO() { id = "B Dog" });
            DogImages.Add(new BreedImageDTO() { id = "C Dog" });
            DogImages.Add(new BreedImageDTO() { id = "D Dog" });
            DogImages.Add(new BreedImageDTO() { id = "E Dog" });

            return DogImages;
        }
    }
}
