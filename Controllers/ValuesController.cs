using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CICDPipelineTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok("hello this is CI CD testing part 3");
        }
        [HttpGet("test1")]
        public IActionResult Test1()
        {
            return Ok("hello this is CI CD testing part7");
        }
    }
}
