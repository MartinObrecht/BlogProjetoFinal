using BlogProjetoFinal.Domain.Entities;

namespace BlogProjetoFinal.Domain.Handlers.Artigo
{
    public class ArtigoResponse
    {
        public ArtigoEntity Data { get; set; }

        public ArtigoResponse(ArtigoEntity data)
        {
            Data = data;
        }
    }
}
