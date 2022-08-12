using MediatR;
using BlogProjetoFinal.Domain.Entities;

namespace BlogProjetoFinal.Domain.Handlers.Artigo.Create
{
    public class CreateArtigoCommand : IRequest
    {
        public ArtigoEntity Body { get; set; }

        public CreateArtigoCommand(ArtigoEntity body)
        {
            Body = body;
        }
    }
}
