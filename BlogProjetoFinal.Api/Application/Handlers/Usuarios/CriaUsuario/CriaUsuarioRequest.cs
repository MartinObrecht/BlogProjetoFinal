using BlogProjetoFinal.Api.Domain.Entities;
using MediatR;

namespace BlogProjetoFinal.Api.Application.Handlers.Usuarios.CriaUsuario
{
    public class CriaUsuarioRequest : IRequest<CriaUsuarioResponse>
    {
        public string Nome { get; set; }
        public string NomeDeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

    }
}
