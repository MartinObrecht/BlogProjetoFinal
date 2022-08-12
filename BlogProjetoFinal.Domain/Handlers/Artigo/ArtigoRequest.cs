using BlogProjetoFinal.Domain.Entities;
using MediatR;

namespace BlogProjetoFinal.Domain.Handlers.Artigo
{
    public class ArtigoRequest : IRequest<ArtigoResponse>
    {
        public ArtigoEntity Body { get; set; }

        public ArtigoRequest(ArtigoEntity body)
        {
            Body = body;
        }
    }
}
