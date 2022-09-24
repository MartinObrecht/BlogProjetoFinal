using BlogProjetoFinal.Domain.Entities;
using BlogProjetoFinal.Domain.Repositories;
using MediatR;

namespace BlogProjetoFinal.Application.Handlers.Usuario.CriaUsuario
{
    public class CriaUsuarioHandler : IRequestHandler<CriaUsuarioRequest, CriaUsuarioResponse>
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public CriaUsuarioHandler(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<CriaUsuarioResponse> Handle(CriaUsuarioRequest request, CancellationToken cancellationToken)
        {
            var novoUsuario = new UsuarioEntity(request.Nome, request.NomeDeUsuario, request.Email, request.Senha);

            var usuario = _usuarioRepository.CriarUsuario(novoUsuario).Result;
            var response = new CriaUsuarioResponse
            {
                NomeDeUsuario = usuario.NomeDeUsuario,
                Email = usuario.Email,
                MensagemRetorno = usuario.MensagemRetorno,
                CodigoRetorno = usuario.CodigoRetorno
            };

            return await Task.FromResult(response);
        }
    }
}
