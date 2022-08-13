using MediatR;
using System;

namespace BlogProjetoFinal.Domain.Handlers.Usuario.Remove
{
    public class RemoveUsuarioCommand : IRequest<RemoveUsuarioCommandResponse>
    {
        public Guid Id { get; set; }

        public RemoveUsuarioCommand(Guid id)
        {
            Id = id;
        }
    }
}
