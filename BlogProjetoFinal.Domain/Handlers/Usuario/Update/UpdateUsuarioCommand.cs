using MediatR;
using BlogProjetoFinal.Domain.Entities;
using System;

namespace BlogProjetoFinal.Domain.Handlers.Usuario.Update
{
    public class UpdateUsuarioCommand : IRequest<UpdateUsuarioCommandResponse>
    {
        public Guid Id { get; set; }
        public UsuarioEntity Usuario { get; set; }
        public UpdateUsuarioCommand(Guid id, UsuarioEntity usuario)
        {
            Id = id;
            Usuario = usuario;
        }
    }
}
