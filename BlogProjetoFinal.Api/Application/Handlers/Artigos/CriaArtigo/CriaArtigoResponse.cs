using System.Text.Json.Serialization;

namespace BlogProjetoFinal.Api.Application.Handlers.Artigos.CriaArtigo
{
    public class CriaArtigoResponse
    {
        public string Conteudo { get; set; }
        public string Titulo { get; set; }
        public string MensagemRetorno { get; set; }
        [JsonIgnore]
        public int CodigoRetorno { get; set; }
    }
}
