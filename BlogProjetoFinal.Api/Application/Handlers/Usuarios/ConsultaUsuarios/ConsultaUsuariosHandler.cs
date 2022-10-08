using BlogProjetoFinal.Api.Domain.Messages;
using BlogProjetoFinal.Api.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjetoFinal.Api.Application.Handlers.Usuarios.ConsultaUsuarios
{
    public class ConsultaUsuariosHandler : IRequestHandler<ConsultaUsuariosRequest, List<ConsultaUsuariosResponse>>
    {
        private readonly IUsuarioRepository _usuarioRepositry;

        public ConsultaUsuariosHandler(IUsuarioRepository usuarioRepositry)
        {
            _usuarioRepositry = usuarioRepositry;
        }

        public async Task<List<ConsultaUsuariosResponse>> Handle(ConsultaUsuariosRequest request, CancellationToken cancellationToken)
        {
            var response = new List<ConsultaUsuariosResponse>();
            var usuarios = _usuarioRepositry.ObterUsuarios().Result;

            if (usuarios.Count > 0)
            {
                foreach (var usuario in usuarios)
                {
                    response.Add(new ConsultaUsuariosResponse
                    {
                        CodigoRetorno = usuario.CodigoRetorno,
                        Email = usuario.Email,
                        MensagemRetorno = MensagensRetornoFields.Sucesso,
                        NomeDeUsuario = usuario.NomeDeUsuario
                    });
                }
            }

            return await Task.FromResult(response);
        }
    }
}
