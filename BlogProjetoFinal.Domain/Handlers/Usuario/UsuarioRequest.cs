using BlogProjetoFinal.Domain.Entities;
using MediatR;

namespace BlogProjetoFinal.Domain.Handlers.Usuario
{
    public class UsuarioRequest : IRequest<UsuarioResponse>
    {
        public Entities.UsuarioEntity Body { get; set; }

        public UsuarioRequest(UsuarioEntity body)
        {
            Body = body;
        }
    }
}
