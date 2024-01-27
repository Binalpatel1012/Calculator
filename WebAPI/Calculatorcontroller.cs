using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        //Add two decimal parameters.
        [HttpGet("Add")]
        public ActionResult<decimal> Add(decimal a, decimal b)
        {
            return a + b;
        }

        //Subtract two decimal parameters.
        [HttpGet("Subtract")]
        public ActionResult<decimal> Subtract(decimal a, decimal b)
        {
            return a - b;
        }

    }
}
