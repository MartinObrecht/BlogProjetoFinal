using BlogProjetoFinal.Application.Handlers.Usuario.ConsultaUsuario;
using MediatR;

namespace BlogProjetoFinal.Application.Handlers.Usuario.ConsultaUsuarios
{
    public class ConsultaUsuariosRequest : IRequest<List<ConsultaUsuarioResponse>>
    {
    }
}