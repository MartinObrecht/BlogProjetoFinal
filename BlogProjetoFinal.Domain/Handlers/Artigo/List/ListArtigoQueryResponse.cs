using BlogProjetoFinal.Domain.Entities;
using System.Collections.Generic;

namespace BlogProjetoFinal.Domain.Handlers.Artigo.List
{
    public class ListArtigoQueryResponse
    {
        public IEnumerable<ArtigoEntity> Data { get; set; }

        public ListArtigoQueryResponse(IEnumerable<ArtigoEntity> data)
        {
            Data = data;
        }
    }
}
