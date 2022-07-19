using IONACodingExercise.Domain.BreedAgg;
using IONACodingExercise.Services;
using IONACodingExercise.WebServices;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IONACodingExercise.Controllers
{
    [Route("api/v{version:apiVersion}")]
    [ApiController]
    [ApiVersion("1")]
    public class BreedsController : ControllerBase
    {
        ICatWebService catWebService;
        IDogWebService dogWebService;
        public BreedsController(ICatWebService _catWebService, IDogWebService _dogWebService)
        {
            catWebService = _catWebService;
            dogWebService = _dogWebService;
        }
        /// <summary>
        /// GET /v1/breeds - Returns a combined paginated list of cat and dog breeds
        /// </summary>
        /// <param name="limit">Specifies the page number to return</param>
        /// <param name="page">Specifies the maximum number of items to return per page</param>
        /// <returns></returns>
        [HttpGet("Breeds")]
        public IActionResult GetBreeds(int limit,int page=1)
        {
            if(limit <= 0)
            {
                return BadRequest("Limit should be at least 1");
            }

            if (page < 1)
            {
                return BadRequest("Page should be at least 1");
            }

            BreedResponseDTO breedResponseDTO = new BreedResponseDTO();
            breedResponseDTO.limit = limit;
            breedResponseDTO.page = page;
            breedResponseDTO.results = new BreedService(catWebService,dogWebService).GetCombinedBreeds(limit, page);

            return Ok(breedResponseDTO);
        }

        /// <summary>
        /// GET /v1/breeds/:breed - Returns a paginated image list of cats or dogs by breed
        /// </summary>
        /// <param name="breed">name of breed, Cat or Dog</param>
        /// <param name="limit">Specifies the page number to return</param>
        /// <param name="page">Specifies the maximum number of items to return per page</param>
        /// <returns></returns>
        [HttpGet("Breeds/{breed}")]
        public IActionResult GetImageListByBreed(string breed, int limit, int page = 1)
        {
            if (limit <= 0)
            {
                return BadRequest("Limit should be at least 1");
            }

            if (page < 1)
            {
                return BadRequest("Page should be at least 1");
            }

            if (string.IsNullOrWhiteSpace(breed))
            {
                return BadRequest("Breed is required");
            }

            BreedResponseDTO breedResponseDTO = new BreedResponseDTO();
            breedResponseDTO.limit = limit;
            breedResponseDTO.page = page;
            breedResponseDTO.results = new BreedService(catWebService, dogWebService).GetBreedImagesByBreed(breed, limit, page);

            return Ok(breedResponseDTO);
        }

        /// <summary>
        /// GET /v1/list - Returns a combined paginated list of cats and dogs
        /// </summary>
        /// <param name="limit">Specifies the page number to return</param>
        /// <param name="page">Specifies the maximum number of items to return per page</param>
        /// <returns></returns>
        [HttpGet("list")]
        public IActionResult GetImageList(int limit, int page = 1)
        {
            if (limit <= 0)
            {
                return BadRequest("Limit should be at least 1");
            }

            if (page < 1)
            {
                return BadRequest("Page should be at least 1");
            }

            BreedResponseDTO breedResponseDTO = new BreedResponseDTO();
            breedResponseDTO.limit = limit;
            breedResponseDTO.page = page;
            breedResponseDTO.results = new BreedService(catWebService, dogWebService).GetCombinedBreedImages(limit, page);

            return Ok(breedResponseDTO);
        }

        /// <summary>
        /// GET /v1/:image - Returns an image of the cat or dog by image ID
        /// </summary>
        /// <param name="image">ImageID of image</param>
        /// <returns></returns>
        [HttpGet("{image}")]
        public IActionResult GetBreedImage(string image)
        {

            BreedImage breedImage = new BreedService(catWebService, dogWebService).GetBreedImageById(image);

            if (breedImage == null)
                return BadRequest("Image not found");

            return Ok(breedImage);
        }
    }
}
