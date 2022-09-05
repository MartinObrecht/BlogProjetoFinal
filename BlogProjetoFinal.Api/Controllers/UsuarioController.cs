using BlogProjetoFinal.Application.Handlers.Usuario.ConsultaUsuario;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BlogProjetoFinal.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsuarioController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> ObterUsuario([FromRoute] Guid id)
        {
            var result = await _mediator.Send(new ConsultaUsuarioRequest(id));

            switch (result.CodigoRetorno)
            {
                case (int)HttpStatusCode.OK:
                    return Ok(result);
                case (int)HttpStatusCode.NotFound:
                    return NotFound(result);
                default:
                    return BadRequest(result);
            }
        }
    }
}
