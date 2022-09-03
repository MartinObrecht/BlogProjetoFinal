using MediatR;

namespace BlogProjetoFinal.Api.Application.Handlers.ConsultaUsuarios
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
