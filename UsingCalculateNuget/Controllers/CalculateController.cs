using CalculateNugetExample;
using Microsoft.AspNetCore.Mvc;

namespace UsingCalculateNuget.Controllers
{
    [ApiController]
    public class CalculateController : ControllerBase
    {
        [HttpGet]
        [Route("api/calculate")]
        public ActionResult Calculate(int val1, int val2)
        {
            var calculate = CalculateMath.Addition(val1,val2);

            return Ok(calculate);
        }
    }
}
