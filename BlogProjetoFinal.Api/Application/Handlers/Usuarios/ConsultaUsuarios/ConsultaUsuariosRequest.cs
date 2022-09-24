using MediatR;

namespace BlogProjetoFinal.Api.Application.Handlers.Usuarios.ConsultaUsuarios
{
    public class ConsultaUsuariosRequest : IRequest<List<ConsultaUsuariosResponse>>
    {
    }
}