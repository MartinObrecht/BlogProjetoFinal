using BlogProjetoFinal.Domain.Entities;

namespace BlogProjetoFinal.Domain.Handlers.Artigo.Read
{
    public class ReadArtigoQueryResponse
    {
        public ArtigoEntity Data { get; set; }

        public ReadArtigoQueryResponse(ArtigoEntity data)
        {
            Data = data;
        }
    }
}
