using System.Text.Json.Serialization;

namespace BlogProjetoFinal.Api.Application.Handlers.Artigos.AtualizarArtigo
{
    public class AtualizarArtigoResponse
    {
        public int Id { get; set; }
        [JsonIgnore]
        public int CodigoRetorno { get; set; }
        public string MensagemRetorno { get; set; }
    }
}
