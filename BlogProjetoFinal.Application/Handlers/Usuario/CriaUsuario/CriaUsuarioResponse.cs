using System.Text.Json.Serialization;

namespace BlogProjetoFinal.Application.Handlers.Usuario.CriaUsuario
{
    public class CriaUsuarioResponse
    {
        public string NomeDeUsuario { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public int CodigoRetorno { get; set; }
        public string MensagemRetorno { get; set; }
    }
}
