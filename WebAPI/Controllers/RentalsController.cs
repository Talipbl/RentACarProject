using Business.Abstracts;
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
    public class RentalsController : ControllerBase
    {
        IRentalService _rentalService;
        ControllerHelper _controllerHelper;

        public RentalsController(IRentalService rentalService)
        {
            _rentalService = rentalService;
            _controllerHelper = new ControllerHelper();
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return _controllerHelper.CheckIfSuccess(_rentalService.GetAll());
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            return _controllerHelper.CheckIfSuccess(_rentalService.Get(id));
        }
        [HttpPost("add")]
        public IActionResult Add(Rental rental)
        {
            return _controllerHelper.CheckIfSuccess(_rentalService.Add(rental));
        }
        [HttpPost("delete")]
        public IActionResult Delete(Rental rental)
        {
            return _controllerHelper.CheckIfSuccess(_rentalService.Delete(rental));
        }
        [HttpPost("update")]
        public IActionResult Update(Rental rental)
        {
            return _controllerHelper.CheckIfSuccess(_rentalService.Update(rental));
        }
    }
}
