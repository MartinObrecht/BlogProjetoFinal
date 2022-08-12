using BlogProjetoFinal.Domain.Entities;

namespace BlogProjetoFinal.Domain.Handlers.Artigo.Remove
{
    public class RemoveArtigoCommandResponse
    {
        public ArtigoEntity Data { get; set; }

        public RemoveArtigoCommandResponse(ArtigoEntity data)
        {
            Data = data;
        }
    }
}
