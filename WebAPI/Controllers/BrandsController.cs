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
    public class BrandsController : ControllerBase
    {
        IBrandService _brandService;
        ControllerHelper _controllerHelper;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
            _controllerHelper = new ControllerHelper();
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return _controllerHelper.CheckIfSuccess(_brandService.GetAll());
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            return _controllerHelper.CheckIfSuccess(_brandService.Get(id));
        }
        [HttpPost("add")]
        public IActionResult Add(Brand brand)
        {
            return _controllerHelper.CheckIfSuccess(_brandService.Add(brand));
        }
        [HttpPost("delete")]
        public IActionResult Delete(Brand brand)
        {
            return _controllerHelper.CheckIfSuccess(_brandService.Delete(brand));
        }
        [HttpPost("update")]
        public IActionResult Update(Brand brand)
        {
            return _controllerHelper.CheckIfSuccess(_brandService.Update(brand));
        }
    }
}
