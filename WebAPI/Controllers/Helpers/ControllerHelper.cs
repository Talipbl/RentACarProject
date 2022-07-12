using Core.Utilities.Results.Abstracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers.Helpers
{
    /// <summary>
    /// Contains helper methods for API controllers. Inherits from ControllerBase to return HTTP status code.
    /// </summary>
    public class ControllerHelper : ControllerBase
    {
        /// <summary>
        /// Send method and check return value if is success or error. Submitted method should return a IResult.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>Returns 'Ok' or 'BadRequest' as Action Result</returns>
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
