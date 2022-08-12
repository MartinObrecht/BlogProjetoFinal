using MediatR;
using BlogProjetoFinal.Domain.Entities;

namespace BlogProjetoFinal.Domain.Handlers.Usuario.Update
{
    public class UpdateUsuarioCommand : IRequest<UpdateUsuarioCommandResponse>
    {
        public UsuarioEntity Body { get; set; }

        public UpdateUsuarioCommand(UsuarioEntity body)
        {
            Body = body;
        }
    }
}
