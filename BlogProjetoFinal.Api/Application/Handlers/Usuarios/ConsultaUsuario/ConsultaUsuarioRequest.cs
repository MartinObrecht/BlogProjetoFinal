using MediatR;

namespace BlogProjetoFinal.Api.Application.Handlers.Usuarios.ConsultaUsuario
{
    public class ConsultaUsuarioRequest : IRequest<ConsultaUsuarioResponse>
    {
        public Guid Id { get; set; }
        public ConsultaUsuarioRequest(Guid id)
        {
            Id = id;
        }
    }
}
