using MediatR;
using System;

namespace BlogProjetoFinal.Domain.Handlers.Artigo.Read
{
    public class ReadArtigoQuery : IRequest<ReadArtigoQueryResponse>
    {
        public int Id { get; set; }

        public ReadArtigoQuery(int id)
        {
            Id = id;
        }
    }
}
