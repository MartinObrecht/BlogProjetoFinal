using System.Text.Json.Serialization;

namespace BlogProjetoFinal.Api.Domain.Entities
{
    public class Usuario : BaseEntity
    {
        [JsonIgnore]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string NomeDeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        [JsonIgnore]
        public DateTime DataCriacao { get; set; }
        [JsonIgnore]
        public DateTime DataAtualizacao { get; set; }
        public virtual ICollection<Artigo> Artigos { get; set; }

        public Usuario()
        {

        }
        public Usuario(string nome, string nomeDeUsuario, string email, string senha)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            NomeDeUsuario = nomeDeUsuario;
            Email = email;
            Senha = senha;
            DataCriacao = DateTime.Now;
            DataAtualizacao = DateTime.Now;
        }

    }
}
