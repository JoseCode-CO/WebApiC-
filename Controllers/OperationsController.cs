using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public decimal Suma(decimal a, decimal b)
        {
            return a + b;
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
}
