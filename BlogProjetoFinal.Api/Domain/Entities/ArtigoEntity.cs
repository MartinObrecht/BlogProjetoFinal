namespace BlogProjetoFinal.Api.Domain.Entities
{
    public class ArtigoEntity : BaseEntity
    {
        public int Id { get; set; }
        public string Autor { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Categoria { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
