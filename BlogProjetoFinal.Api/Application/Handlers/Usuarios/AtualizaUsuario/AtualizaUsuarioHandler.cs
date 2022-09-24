using BlogProjetoFinal.Api.Domain.Entities;
using BlogProjetoFinal.Api.Domain.Messages;
using BlogProjetoFinal.Api.Domain.Repositories;
using MediatR;
using System.Net;

namespace BlogProjetoFinal.Api.Application.Handlers.Usuarios.AtualizaUsuario
{
    public class AtualizaUsuarioHandler : IRequestHandler<AtualizaUsuarioRequest, AtualizaUsuarioResponse>
    {
        private readonly IUsuarioRepository _usuarioRepositry;

        public AtualizaUsuarioHandler(IUsuarioRepository usuarioRepositry)
        {
            _usuarioRepositry = usuarioRepositry;
        }

        public async Task<AtualizaUsuarioResponse> Handle(AtualizaUsuarioRequest request, CancellationToken cancellationToken)
        {
            var usuario = _usuarioRepositry.ObterUsuario(request.Id).Result;

            usuario.NomeDeUsuario = request.NomeDeUsuario;
            usuario.Senha = request.Senha;
            usuario.DataCriacao = usuario.DataCriacao;
            usuario.DataAtualizacao = DateTime.Now;
            usuario.Email = request.Email;
            usuario.MensagemRetorno = MensagensRetornoFields.UsuarioAtualizado;
            usuario.CodigoRetorno = (int)HttpStatusCode.OK;

            await _usuarioRepositry.AtualizaUsuario(usuario);

            return await Task.FromResult(
                new AtualizaUsuarioResponse { 
                    NomeDeUsuario = usuario.NomeDeUsuario, 
                    Email = usuario.Email, 
                    CodigoRetorno = usuario.CodigoRetorno, 
                    MensagemRetorno = usuario.MensagemRetorno
                });
        }
    }
}
