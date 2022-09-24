using BlogProjetoFinal.Api.Application.Handlers.Usuarios.AtualizaUsuario;
using BlogProjetoFinal.Api.Application.Handlers.Usuarios.ConsultaUsuario;
using BlogProjetoFinal.Api.Application.Handlers.Usuarios.ConsultaUsuarios;
using BlogProjetoFinal.Api.Application.Handlers.Usuarios.CriaUsuario;
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

        [HttpGet]
        public async Task<IActionResult> ObterUsuarios()
        {
            var result = await _mediator.Send(new ConsultaUsuariosRequest());

            switch (result.FirstOrDefault().CodigoRetorno)
            {
                case (int)HttpStatusCode.OK:
                    return Ok(result);
                case (int)HttpStatusCode.NotFound:
                    return NotFound(result);
                default:
                    return BadRequest(result);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CriarUsuario([FromBody] CriaUsuarioRequest usuario)
        {
            var result = await _mediator.Send(usuario);

            switch (result.CodigoRetorno)
            {
                case (int)HttpStatusCode.Created:
                    return StatusCode(result.CodigoRetorno, result);
                case (int)HttpStatusCode.NotAcceptable:
                    return StatusCode(result.CodigoRetorno, result.MensagemRetorno);
                case (int)HttpStatusCode.InternalServerError:
                    return StatusCode(result.CodigoRetorno, result.MensagemRetorno);
                default:
                    return BadRequest(result.CodigoRetorno);
            }
        }

        [HttpPut]
        public async Task<IActionResult> AtualizaUsuatio([FromBody] AtualizaUsuarioRequest usuarioAtualizado)
        {
            var result = await _mediator.Send(usuarioAtualizado);

            switch (result.CodigoRetorno)
            {
                case (int)HttpStatusCode.OK:
                    return StatusCode(result.CodigoRetorno, result);
                case (int)HttpStatusCode.NotAcceptable:
                    return StatusCode(result.CodigoRetorno, result.MensagemRetorno);
                case (int)HttpStatusCode.InternalServerError:
                    return StatusCode(result.CodigoRetorno, result.MensagemRetorno);
                default:
                    return BadRequest(result.CodigoRetorno);
            }
        }
    }
}
