using Business.Abstracts;
using Core.Utilities.Results.Abstracts;
using Entities.Concretes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Controllers.Helpers;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;
        ControllerHelper _controllerHelper;
        public CarsController(ICarService carService)
        {
            _carService = carService;
            _controllerHelper = new ControllerHelper();
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return _controllerHelper.CheckIfSuccess(_carService.GetAll());
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            return _controllerHelper.CheckIfSuccess(_carService.Get(id));
        }
        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            return _controllerHelper.CheckIfSuccess(_carService.Add(car));
        }
        [HttpPost("delete")]
        public IActionResult Delete(int carId)
        {
            return _controllerHelper.CheckIfSuccess(_carService.Delete(carId));
        }
        [HttpPost("update")]
        public IActionResult Update(Car car)
        {
            return _controllerHelper.CheckIfSuccess(_carService.Update(car));
        }

    }
}
