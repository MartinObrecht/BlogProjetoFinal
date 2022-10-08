using MediatR;

namespace BlogProjetoFinal.Api.Application.Handlers.Artigos.AtualizarArtigo
{
    public class AtualizarArtigoRequest : IRequest<AtualizarArtigoResponse>
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataAtualizacao { get; set; }
        public AtualizarArtigoRequest(int id, int categoriaId, string titulo, string conteudo, DateTime dataAtualizacao)
        {
            Id = id;
            Titulo = titulo;
            Conteudo = conteudo;
            DataAtualizacao = DateTime.Now;
        }

    }
}
