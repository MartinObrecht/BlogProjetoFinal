using MediatR;
using BlogProjetoFinal.Domain.Entities;

namespace BlogProjetoFinal.Domain.Handlers.Artigo.Update
{
    public class UpdateArtigoCommand : IRequest<UpdateArtigoCommandResponse>
    {
        public ArtigoEntity Body { get; set; }

        public UpdateArtigoCommand(ArtigoEntity body)
        {
            Body = body;
        }
    }
}
