using Business.Abstracts;
using Entities.Concretes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Controllers.Helpers;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;
        ControllerHelper _controllerHelper;

        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
            _controllerHelper = new ControllerHelper();
        }
        [HttpPost("upload")]
        public IActionResult Upload(IFormFile formFile,int carId)
        {
            return _controllerHelper.CheckIfSuccess(_carImageService.Add(formFile, carId));
        }
        [HttpGet("getimages")]
        public IActionResult Getımages(int carId)
        {
            return _controllerHelper.CheckIfSuccess(_carImageService.GetAll(carId));
        }
        [HttpGet("delete")]
        public IActionResult Delete(int imageId)
        {
            return _controllerHelper.CheckIfSuccess(_carImageService.Delete(imageId));
        }
        [HttpPost("update")]
        public IActionResult Delete(CarImage carImage)
        {
            return _controllerHelper.CheckIfSuccess(_carImageService.Update(carImage));
        }
    }
}
