using System.Text.Json.Serialization;

namespace BlogProjetoFinal.Application.Handlers.Usuario.ConsultaUsuario
{
    public class ConsultaUsuarioResponse
    {
        public string NomeDeUsuario { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public int CodigoRetorno { get; set; }
        [JsonIgnore]
        public string MensagemRetorno { get; set; }
    }
}
