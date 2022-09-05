using BlogProjetoFinal.Domain.Repositories;
using MediatR;

namespace BlogProjetoFinal.Application.Handlers.Usuario.CriaUsuario
{
    public class CriaUsuarioHandler : IRequestHandler<CriaUsuarioRequest, CriaUsuarioResponse>
    {
        private readonly IUsuarioRepository _usuarioRepositry;

        public CriaUsuarioHandler(IUsuarioRepository usuarioRepositry)
        {
            _usuarioRepositry = usuarioRepositry;
        }

        public async Task<CriaUsuarioResponse> Handle(CriaUsuarioRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
