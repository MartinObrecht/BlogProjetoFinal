namespace BlogProjetoFinal.Api.Domain.Entities
{
    public class Categoria : BaseEntity
    {
        public int Id { get; set; }
        public string NomeCategoria { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public virtual ICollection<Artigo> Artigos { get; set; }
    }
}