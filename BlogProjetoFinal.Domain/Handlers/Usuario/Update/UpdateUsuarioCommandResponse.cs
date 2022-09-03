using BlogProjetoFinal.Domain.Entities;

namespace BlogProjetoFinal.Domain.Handlers.Usuario.Update
{
    public class UpdateUsuarioCommandResponse
    {
        public string Nome { get; set; }
        public string NomeDeUsuario { get; set; }
        public string Email { get; set; }

        public UpdateUsuarioCommandResponse(string nome, string nomeDeUsuario, string email)
        {
            Nome = nome;
            NomeDeUsuario = nomeDeUsuario;
            Email = email;
        }
    }
}
