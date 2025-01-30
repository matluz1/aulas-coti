using Microsoft.AspNetCore.Mvc;

namespace GestaoDeProdutos.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstoquesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
