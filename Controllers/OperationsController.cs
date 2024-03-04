using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationsController : ControllerBase
    {
        [HttpGet]
        public decimal Numero(decimal a, decimal b)
        {
            return a + b;
        }

        [HttpPost]
        public decimal Suma(Numbers numbers)
        {
            return numbers.B + numbers.A;
        }

        [HttpPut]
        public decimal Resta(decimal a, decimal b)
        {
            return a - b;
        }

        [HttpDelete]
        public decimal Multiplicacion(decimal a, decimal b)
        {
            return a * b;
        }

       
    }
    public class Numbers
    {
        public decimal A { get; set; }
        public decimal B { get; set; }
    }
}
