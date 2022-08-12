using BlogProjetoFinal.Domain.Entities;

namespace BlogProjetoFinal.Domain.Handlers.Artigo.Update
{
    public class UpdateArtigoCommandResponse
    {
        public ArtigoEntity Data { get; set; }

        public UpdateArtigoCommandResponse(ArtigoEntity data)
        {
            Data = data;
        }
    }
}
