using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using AuthDummyService.Models;

namespace AuthDummyService.Controllers
{
    [Route("")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // POST: login dummy con valores en definidos
        [HttpPost("/login")]
        [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Login(User usuario)
        {
            if (usuario.userId == "matias.araya" && usuario.password == "Holamundo") return Ok(usuario);
            return BadRequest();
        }        
    }
}
