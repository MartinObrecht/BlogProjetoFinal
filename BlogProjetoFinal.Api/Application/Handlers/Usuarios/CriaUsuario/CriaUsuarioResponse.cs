using System.Text.Json.Serialization;

namespace BlogProjetoFinal.Api.Application.Handlers.Usuarios.CriaUsuario
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
