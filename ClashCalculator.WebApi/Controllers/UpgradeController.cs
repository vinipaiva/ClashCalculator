using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace ClashCalculator.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Upgrade")]
    public class UpgradeController : Controller
    {
        
        [Route("{townHallLevel")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(string), Description = "Action successfully saved")]
        [HttpGet]
        public IActionResult GetAllUpgradableUnits(int? townHallLevel)
        {
            return Ok();
        }

        
    }
}
