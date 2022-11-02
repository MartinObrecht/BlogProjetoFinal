using MediatR;
using System.Text.Json.Serialization;

namespace BlogProjetoFinal.Api.Application.Handlers.Artigos.ConsultaArtigo
{
    public class ConsultaArtigoResponse : IRequest<ConsultaArtigoResponse>
    {
        public string NomeUsuario { get; set; }
        public string Conteudo { get; set; }
        public string Titulo { get; set; }
        public string Categoria { get; set; }
        public string MensagemRetorno { get; set; }
        [JsonIgnore]
        public int CodigoRetorno { get; set; }
    }
}
