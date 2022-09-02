using Liquid.WebApi.Http.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using BlogProjetoFinal.Domain.Handlers.Artigo;
using BlogProjetoFinal.Domain.Handlers.Artigo.Read;
using BlogProjetoFinal.Domain.Handlers.Artigo.List;
using BlogProjetoFinal.Domain.Entities;
using BlogProjetoFinal.Domain.Handlers.Artigo.Create;
using BlogProjetoFinal.Domain.Handlers.Artigo.Update;
using BlogProjetoFinal.Domain.Handlers.Artigo.Remove;
using System;

namespace BlogProjetoFinal.WebApi.Controllers
{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class ArtigoController : LiquidControllerBase
//    {
//        public ArtigoController(IMediator mediator) : base(mediator)
//        {
//        }

//        [HttpGet("{id}")]
//        [ProducesResponseType(StatusCodes.Status200OK)]

//        public async Task<IActionResult> Get([FromRoute] int id)
//        {
//            var response = await ExecuteAsync(new ReadArtigoQuery(id));

//            if (response.Data == null) return NotFound();

//            return Ok(response.Data);
//        }

//        [HttpGet]
//        [ProducesResponseType(StatusCodes.Status200OK)]
//        public async Task<IActionResult> Get()
//        {
//            var response = await ExecuteAsync(new ListArtigoQuery());

//            if (response.Data == null) return NotFound();

//            return Ok(response.Data);
//        }

//        [HttpPost]
//        [ProducesResponseType(StatusCodes.Status201Created)]
//        public async Task<IActionResult> Post([FromBody] ArtigoEntity entity)
//        {
//            await ExecuteAsync(new CreateArtigoCommand(entity));

//            return CreatedAtRoute("", new { id = entity.Id }, entity);
//        }

//        [HttpPut]
//        [ProducesResponseType(StatusCodes.Status204NoContent)]
//        public async Task<IActionResult> Put([FromBody] ArtigoEntity entity)
//        {
//            var response = await ExecuteAsync(new UpdateArtigoCommand(entity));

//            if (response.Data == null) return NotFound();

//            return NoContent();
//        }

//        [HttpDelete("{id}")]
//        [ProducesResponseType(StatusCodes.Status204NoContent)]
//        public async Task<IActionResult> Delete([FromRoute] int id)
//        {
//            var response = await ExecuteAsync(new RemoveArtigoCommand(id));

//            if (response.Data == null) return NotFound();

//            return NoContent();
//        }
//    }
}