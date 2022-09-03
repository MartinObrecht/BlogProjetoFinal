using BlogProjetoFinal.Api.Application.Handlers.ConsultaUsuarios;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogProjetoFinal.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsuarioController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("v1/Usuario")]
        public async Task<IActionResult> ObterUsuario(Guid id)
        {
            var result = await _mediator.Send(new ConsultaUsuarioRequest(id));

            return Ok(result);
        }
    }
}
