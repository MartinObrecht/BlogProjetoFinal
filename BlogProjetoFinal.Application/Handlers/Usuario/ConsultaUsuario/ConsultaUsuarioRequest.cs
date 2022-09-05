using MediatR;

namespace BlogProjetoFinal.Application.Handlers.Usuario.ConsultaUsuario
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
