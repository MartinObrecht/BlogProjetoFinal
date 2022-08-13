using Liquid.WebApi.Http.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using BlogProjetoFinal.Domain.Entities;
using BlogProjetoFinal.Domain.Handlers.Usuario.Create;
using BlogProjetoFinal.Domain.Handlers.Usuario.Remove;
using BlogProjetoFinal.Domain.Handlers.Usuario.Read;
using BlogProjetoFinal.Domain.Handlers.Usuario.Update;
using BlogProjetoFinal.Domain.Handlers.Usuario.List;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System;

namespace BlogProjetoFinal.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : LiquidControllerBase
    {
        public UsuarioController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var response = await ExecuteAsync(new ReadUsuarioQuery(id));

            if (response.Data == null) return NotFound();

            return Ok(response.Data);
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> Get()
        {
            var response = await ExecuteAsync(new ListUsuarioQuery());

            if (response.Data == null) return NotFound();

            return Ok(response.Data);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Post([FromBody] UsuarioEntity entity)
        {
            await ExecuteAsync(new CreateUsuarioCommand(entity));

            return CreatedAtAction(nameof(GetById), new { id = entity.Id }, entity);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Put([FromBody] UsuarioEntity entity)
        {
            var response = await ExecuteAsync(new UpdateUsuarioCommand(entity));

            if (response.Data == null) return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var response = await ExecuteAsync(new RemoveUsuarioCommand(id));

            if (response.Data == null) return NotFound();

            return NoContent();
        }
    }
}