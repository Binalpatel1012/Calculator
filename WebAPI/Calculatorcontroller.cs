using Microsoft.AspNetCore.Mvc;
using CalculatorLibrary; // Ensure this using statement is added to reference the CalculatorLibrary

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private readonly Calculator _calculator;

        public CalculatorController()
        {
            _calculator = new Calculator();
        }

        [HttpGet("Add")]
        public ActionResult<decimal> Add(decimal a, decimal b)
        {
            return _calculator.Add(a, b);
        }

        [HttpGet("Subtract")]
        public ActionResult<decimal> Subtract(decimal a, decimal b)
        {
            try
            {
                return _calculator.Subtract(a, b);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Multiply")]
        public ActionResult<decimal> Multiply(decimal a, decimal b)
        {
            return _calculator.Multiply(a, b);
        }

        [HttpGet("Divide")]
        public ActionResult<decimal> Divide(decimal a, decimal b)
        {
            try
            {
                return _calculator.Divide(a, b);
            }
            catch (DivideByZeroException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Modulo")]
        public ActionResult<decimal> Modulo(decimal a, decimal b)
        {
            try
            {
                return _calculator.Modulo(a, b);
            }
            catch (DivideByZeroException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
