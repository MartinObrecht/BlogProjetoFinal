using MediatR;
using System;

namespace BlogProjetoFinal.Domain.Handlers.Usuario.Remove
{
    public class RemoveUsuarioCommand : IRequest<RemoveUsuarioCommandResponse>
    {
        public int Id { get; set; }

        public RemoveUsuarioCommand(int id)
        {
            Id = id;
        }
    }
}
