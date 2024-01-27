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

        //Multiply two decimal parameters.
        [HttpGet("Multiply")]
        public ActionResult<decimal> Multiply(decimal a, decimal b)
        {
            return a * b;
        }

        //Divide two decimal parameters.
        [HttpGet("Divide")]
        public ActionResult<decimal> Divide(decimal a, decimal b)
        {
            if (b == 0)
            {
                return BadRequest("Division by zero is not allowed.");
            }
            return a / b;
        }

        
    }
}
