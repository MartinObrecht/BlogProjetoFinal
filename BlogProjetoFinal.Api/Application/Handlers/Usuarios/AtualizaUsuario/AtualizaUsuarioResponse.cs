using System.Text.Json.Serialization;

namespace BlogProjetoFinal.Api.Application.Handlers.Usuarios.AtualizaUsuario
{
    public class AtualizaUsuarioResponse
    {
        public string NomeDeUsuario { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public int CodigoRetorno { get; set; }
        public string MensagemRetorno { get; set; }
    }
}
