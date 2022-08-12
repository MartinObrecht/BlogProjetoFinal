using BlogProjetoFinal.Domain.Entities;
using BlogProjetoFinal.Domain.Handlers.Artigo;
using Liquid.WebApi.Http.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace BlogProjetoFinal.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArtigoController : LiquidControllerBase
    {
        public ArtigoController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> MyCommand([FromBody] ArtigoEntity entity) => await ExecuteAsync(new ArtigoRequest(entity), HttpStatusCode.OK);

    }
}