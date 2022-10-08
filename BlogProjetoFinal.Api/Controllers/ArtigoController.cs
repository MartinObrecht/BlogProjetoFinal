using BlogProjetoFinal.Api.Application.Handlers.Artigos.ConsultaArtigo;
using BlogProjetoFinal.Api.Application.Handlers.Artigos.ConsultaArtigos;
using BlogProjetoFinal.Api.Application.Handlers.Artigos.CriaArtigo;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BlogProjetoFinal.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ArtigoController : Controller
    {
        private readonly IMediator _mediator;

        public ArtigoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CriarArtigo([FromBody] CriaArtigoRequest artigo)
        {
            var result = await _mediator.Send(artigo);

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

        [HttpGet]
        public async Task<IActionResult> ObterArtigos()
        {
            var result = await _mediator.Send(new ConsultaArtigosRequest());

            return result.FirstOrDefault().CodigoRetorno switch
            {
                (int)HttpStatusCode.OK => Ok(result),
                (int)HttpStatusCode.NotFound => NotFound(result),
                _ => BadRequest(result),
            };  
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> ObterArtigo([FromRoute] int id)
        {
            var result = await _mediator.Send(new ConsultaArtigoRequest(id));

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
