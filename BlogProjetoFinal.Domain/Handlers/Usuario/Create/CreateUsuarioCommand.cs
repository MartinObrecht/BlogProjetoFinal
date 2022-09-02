using MediatR;
using BlogProjetoFinal.Domain.Entities;
using System;
using System.Text.Json.Serialization;

namespace BlogProjetoFinal.Domain.Handlers.Usuario.Create
{
    public class CreateUsuarioCommand : IRequest
    {
        public string Nome { get; set; }
        public string NomeDeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public CreateUsuarioCommand(UsuarioEntity body)
        {
            Nome = body.Nome;
            NomeDeUsuario = body.NomeDeUsuario;
            Email = body.Email;
            Senha = body.Senha;
        }
    }
}
