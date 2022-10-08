using System.Text.Json.Serialization;

namespace BlogProjetoFinal.Api.Application.Handlers.Artigos.RemoverArtigo
{
    public class RemoverArtigoResponse
    {
        [JsonIgnore]
        public int CodigoRetorno { get; set; }
        public string MensagemRetorno { get; set; }
    }
}
