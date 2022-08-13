using MediatR;
using System;

namespace BlogProjetoFinal.Domain.Handlers.Artigo.Read
{
    public class ReadArtigoQuery : IRequest<ReadArtigoQueryResponse>
    {
        public Guid Id { get; set; }

        public ReadArtigoQuery(Guid id)
        {
            Id = id;
        }
    }
}
