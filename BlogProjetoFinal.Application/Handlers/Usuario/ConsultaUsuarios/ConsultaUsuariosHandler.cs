using BlogProjetoFinal.Application.Handlers.Usuario.ConsultaUsuario;
using BlogProjetoFinal.Domain.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjetoFinal.Application.Handlers.Usuario.ConsultaUsuarios
{
    public class ConsultaUsuariosHandler : IRequestHandler<ConsultaUsuariosRequest, List<ConsultaUsuarioResponse>>
    {
        private readonly IUsuarioRepository _usuarioRepositry;

        public ConsultaUsuariosHandler(IUsuarioRepository usuarioRepositry)
        {
            _usuarioRepositry = usuarioRepositry;
        }

        public async Task<List<ConsultaUsuarioResponse>> Handle(ConsultaUsuariosRequest request, CancellationToken cancellationToken)
        {
            var response = new List<ConsultaUsuarioResponse>();
            var usuarios = _usuarioRepositry.ObterUsuarios().Result;

            if (usuarios.Count > 0)
            {
                foreach (var usuario in usuarios)
                {
                    response.Add(new ConsultaUsuarioResponse
                    {
                        CodigoRetorno = usuario.CodigoRetorno,
                        Email = usuario.Email,
                        MensagemRetorno = usuario.MensagemRetorno,
                        NomeDeUsuario = usuario.NomeDeUsuario
                    });
                }
            }
            else
            {
                response.Add(new ConsultaUsuarioResponse
                {
                    MensagemRetorno = "Ajustar implementação"
                });
            }

            return await Task.FromResult(response);
        }
    }
}
