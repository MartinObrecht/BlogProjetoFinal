using BlogProjetoFinal.Api.Domain.Entities;
using BlogProjetoFinal.Api.Domain.Repositories;
using MediatR;

namespace BlogProjetoFinal.Api.Application.Handlers.Usuarios.ConsultaUsuario
{
    public class ConsultaUsuarioHandler : IRequestHandler<ConsultaUsuarioRequest, ConsultaUsuarioResponse>
    {
        private readonly IUsuarioRepository _usuarioRepositry;

        public ConsultaUsuarioHandler(IUsuarioRepository usuarioRepositry)
        {
            _usuarioRepositry = usuarioRepositry;
        }

        public async Task<ConsultaUsuarioResponse> Handle(ConsultaUsuarioRequest request, CancellationToken cancellationToken)
        {
            var usuario = new Domain.Entities.Usuario();
            var response = new ConsultaUsuarioResponse();

            usuario = await _usuarioRepositry.ObterUsuario(request.Id);

            response.NomeDeUsuario = usuario.NomeDeUsuario;
            response.Email = usuario.Email;
            response.CodigoRetorno = usuario.CodigoRetorno;
            response.MensagemRetorno = usuario.MensagemRetorno;

            return await Task.FromResult(response);
        }
    }
}
