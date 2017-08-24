using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.BaseApp.Controllers
{
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        private readonly ILogger _logger;
        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var test = 100;
            _logger.LogInformation(1000, "Testing logging information {test}", test);
            return new string[] { "value1", "value2" };
        }

        // GET api/test/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/test
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [Route("exception")]
        [HttpGet]
        public void ThrowException()
        {
            throw new Exception("Sample exception");
        }

        /// <summary>
        /// This method will create multiple values at once
        /// </summary>
        /// <param name="values"></param>
        [Route("multiple")]
        [HttpPost]
        public IActionResult CreateMultipleValues(string[] values)
        {
            return Ok();
        }

        // PUT api/test/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/test/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
