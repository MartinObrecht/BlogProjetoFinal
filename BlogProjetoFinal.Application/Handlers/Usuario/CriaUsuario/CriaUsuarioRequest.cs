using BlogProjetoFinal.Domain.Entities;
using MediatR;

namespace BlogProjetoFinal.Application.Handlers.Usuario.CriaUsuario
{
    public class CriaUsuarioRequest : IRequest<CriaUsuarioResponse>
    {
        public string Nome { get; set; }
        public string NomeDeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

    }
}
