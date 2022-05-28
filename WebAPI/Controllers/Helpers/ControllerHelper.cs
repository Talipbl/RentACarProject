using Core.Utilities.Results.Abstracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers.Helpers
{
    public class ControllerHelper : ControllerBase
    {
        public IActionResult CheckIfSuccess(IResult result)
        {
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
