using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        //Create a method named Add, and ensure that it accepts a get request and Add two decimal parameters.
        [HttpGet("Add")]
        public ActionResult<decimal> Add(decimal a, decimal b)
        {
            return a + b;
        }

        //Create a method named Subtract, and ensure that it accepts a get request and Add two decimal parameters.
        [HttpGet("Subtract")]
        public ActionResult<decimal> Subtract(decimal a, decimal b)
        {
            return a - b;
        }

        //Create a method named Multiply, and ensure that it accepts a get request and two decimal parameters.
        [HttpGet("Multiply")]
        public ActionResult<decimal> Multiply(decimal a, decimal b)
        {
            return a * b;
        }

        //Create a method named Divide, and ensure that it accepts a get request and two decimal parameters.
        [HttpGet("Divide")]
        public ActionResult<decimal> Divide(decimal a, decimal b)
        {
            if (b == 0)
            {
                return BadRequest("Division by zero is not allowed!");
            }
            return a / b;
        }

        //Create a method named Modulo, and ensure that it accepts a get request and two decimal parameters.
        [HttpGet("Modulo")]
        public ActionResult<decimal> Modulo(decimal a, decimal b)
        {
            if (b == 0)
            {
                return BadRequest("Modulo by zero is not allowed!");
            }
            return a % b;
        }

    }
}
