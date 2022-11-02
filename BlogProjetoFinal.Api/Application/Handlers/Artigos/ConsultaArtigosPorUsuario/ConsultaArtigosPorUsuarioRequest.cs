using MediatR;

namespace BlogProjetoFinal.Api.Application.Handlers.Artigos.ConsultaArtigosPorUsuario
{
    public class ConsultaArtigosPorUsuarioRequest : IRequest<List<ConsultaArtigosPorUsuarioResponse>>
    {
        public Guid Id { get; set; }
        public ConsultaArtigosPorUsuarioRequest(Guid id)
        {
            Id = id;
        }
    }
}
