using MediatR;
using System;

namespace BlogProjetoFinal.Domain.Handlers.Artigo.Remove
{
    public class RemoveArtigoCommand : IRequest<RemoveArtigoCommandResponse>
    {
        public int Id { get; set; }

        public RemoveArtigoCommand(int id)
        {
            Id = id;
        }
    }
}
