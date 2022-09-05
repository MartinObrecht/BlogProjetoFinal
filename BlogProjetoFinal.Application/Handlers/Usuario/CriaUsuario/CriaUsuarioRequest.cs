using BlogProjetoFinal.Domain.Entities;
using MediatR;

namespace BlogProjetoFinal.Application.Handlers.Usuario.CriaUsuario
{
    public class CriaUsuarioRequest : IRequest<CriaUsuarioResponse>
    {
        public UsuarioEntity NovoUsuario { get; set; }
        public CriaUsuarioRequest(UsuarioEntity novoUsuario)
        {
            NovoUsuario = novoUsuario;
        }
    }
}
