using MediatR;
using System;

namespace BlogProjetoFinal.Domain.Handlers.Artigo.Remove
{
    public class RemoveArtigoCommand : IRequest<RemoveArtigoCommandResponse>
    {
        public Guid Id { get; set; }

        public RemoveArtigoCommand(Guid id)
        {
            Id = id;
        }
    }
}
