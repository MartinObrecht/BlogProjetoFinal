namespace BlogProjetoFinal.Domain.Entities
{
    public class ArtigoEntity : BaseEntity
    {
        public int ID { get; set; }
        public int CategoriaEntityID { get; set; }
        public Guid UsuarioEntityID { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public CategoriaEntity Categoria { get; set; }
        public UsuarioEntity Usuario { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
