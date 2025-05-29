using Microsoft.AspNetCore.Mvc;

namespace paroimpar.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParImparController : ControllerBase
    {
        [HttpGet("{numero}")]
        public IActionResult GetParImpar(int numero)
        {
            string resultado = (numero % 2 == 0) ? "Par" : "Impar";
            return Ok(new { Numero = numero, Resultado = resultado });
        }
    }
}
