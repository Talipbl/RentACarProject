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
    public class CustomersController : ControllerBase
    {
        ICustomerService _customerService;
        ControllerHelper _controllerHelper;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
            _controllerHelper = new ControllerHelper();
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return _controllerHelper.CheckIfSuccess(_customerService.GetAll());
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            return _controllerHelper.CheckIfSuccess(_customerService.Get(id));
        }
        [HttpPost("add")]
        public IActionResult Add(Customer customer)
        {
            return _controllerHelper.CheckIfSuccess(_customerService.Add(customer));
        }
        [HttpPost("delete")]
        public IActionResult Delete(Customer customer)
        {
            return _controllerHelper.CheckIfSuccess(_customerService.Delete(customer));
        }
        [HttpPost("update")]
        public IActionResult Update(Customer customer)
        {
            return _controllerHelper.CheckIfSuccess(_customerService.Update(customer));
        }
    }
}
