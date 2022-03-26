using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Supermercado.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriaController : Controller
    {
        private readonly IMediator _mediator;
        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            return Ok("ok");
        }
    }
}
