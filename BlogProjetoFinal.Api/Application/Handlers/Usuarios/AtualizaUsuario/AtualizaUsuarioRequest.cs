using MediatR;

namespace BlogProjetoFinal.Api.Application.Handlers.Usuarios.AtualizaUsuario
{
    public class AtualizaUsuarioRequest : IRequest<AtualizaUsuarioResponse>
    {
        public Guid Id { get; set; }
        public string NomeDeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public AtualizaUsuarioRequest(Guid id, string nomeDeUsuario, string email, string senha)
        {
            Id = id;
            NomeDeUsuario = nomeDeUsuario;
            Email = email;
            Senha = senha;
        }
    }
}
