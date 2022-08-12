using BlogProjetoFinal.Domain.Entities;
using BlogProjetoFinal.Domain.Handlers.Usuario;
using Liquid.WebApi.Http.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace BlogProjetoFinal.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : LiquidControllerBase
    {
        public UsuarioController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> MyCommand([FromBody] UsuarioEntity entity) => await ExecuteAsync(new UsuarioRequest(entity), HttpStatusCode.OK);

    }
}