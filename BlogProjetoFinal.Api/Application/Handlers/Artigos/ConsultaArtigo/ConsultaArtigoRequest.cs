using MediatR;

namespace BlogProjetoFinal.Api.Application.Handlers.Artigos.ConsultaArtigo
{
    public class ConsultaArtigoRequest : IRequest<ConsultaArtigoResponse>
    {
        public ConsultaArtigoRequest(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}