using MediatR;
using BlogProjetoFinal.Domain.Entities;

namespace BlogProjetoFinal.Domain.Handlers.Usuario.Create
{
    public class CreateUsuarioCommand : IRequest
    {
        public UsuarioEntity Body { get; set; }

        public CreateUsuarioCommand(UsuarioEntity body)
        {
            Body = body;
        }
    }
}
