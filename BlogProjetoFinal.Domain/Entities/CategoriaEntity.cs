namespace BlogProjetoFinal.Domain.Entities
{
    public class CategoriaEntity : BaseEntity
    {
        public int ID { get; set; }
        public string NomeCategoria { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public virtual ICollection<ArtigoEntity> Artigos { get; set; }
    }
}