using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("Add")]
        public ActionResult<decimal> Add(decimal a, decimal b)
        {
            return a + b;
        }

    }
}
