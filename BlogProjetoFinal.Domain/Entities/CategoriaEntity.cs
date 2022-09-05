namespace BlogProjetoFinal.Domain.Entities
{
    public class CategoriaEntity : BaseEntity
    {
        public int Id { get; set; }
        public string NomeCategoria { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}