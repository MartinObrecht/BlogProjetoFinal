using System.Text.Json.Serialization;

namespace BlogProjetoFinal.Api.Application.Handlers.Usuarios.ConsultaUsuarios
{
    public class ConsultaUsuariosResponse
    {
        public string NomeDeUsuario { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public int CodigoRetorno { get; set; }
        [JsonIgnore]
        public string MensagemRetorno { get; set; }

    }
}
