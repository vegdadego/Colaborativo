using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TuProyecto.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PalindromoController : ControllerBase
    {
        [HttpGet("{entrada}")]
        public IActionResult EsPalindromo(string entrada)
        {
            if (string.IsNullOrWhiteSpace(entrada))
                return BadRequest("Debes ingresar una palabra o frase.");

            // Normalizamos: quitamos espacios y convertimos a minúsculas
            string original = new string(entrada
                .Where(char.IsLetterOrDigit)
                .Select(char.ToLower)
                .ToArray());

            string invertida = new string(original.Reverse().ToArray());

            bool esPalindromo = original == invertida;

            return Ok(new
            {
                entrada = entrada,
                resultado = esPalindromo ? "Es un palíndromo" : "No es un palíndromo"
            });
        }
    }
}
