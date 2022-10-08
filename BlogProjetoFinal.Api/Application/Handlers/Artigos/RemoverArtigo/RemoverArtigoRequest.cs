using MediatR;

namespace BlogProjetoFinal.Api.Application.Handlers.Artigos.RemoverArtigo
{
    public class RemoverArtigoRequest : IRequest<RemoverArtigoResponse>
    {
        public int Id { get; set; }
        public RemoverArtigoRequest(int id)
        {
            Id = id;
        }
    }
}
