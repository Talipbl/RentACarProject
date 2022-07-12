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
    public class ColorsController : ControllerBase
    {
        IColorService _colorService;
        ControllerHelper _controllerHelper;
        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
            _controllerHelper = new ControllerHelper();
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return _controllerHelper.CheckIfSuccess(_colorService.GetAll());
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            return _controllerHelper.CheckIfSuccess(_colorService.Get(id));
        }
        [HttpPost("add")]
        public IActionResult Add(Color color)
        {
            return _controllerHelper.CheckIfSuccess(_colorService.Add(color));
        }
        [HttpPost("delete")]
        public IActionResult Delete(int colorId)
        {
            return _controllerHelper.CheckIfSuccess(_colorService.Delete(colorId));
        }
        [HttpPost("update")]
        public IActionResult Update(Color color)
        {
            return _controllerHelper.CheckIfSuccess(_colorService.Update(color));
        }

    }
}
