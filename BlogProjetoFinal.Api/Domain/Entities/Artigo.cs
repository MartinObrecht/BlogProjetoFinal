namespace BlogProjetoFinal.Api.Domain.Entities
{
    public class Artigo : BaseEntity
    {
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public Guid UsuarioId { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public Categoria Categoria { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
