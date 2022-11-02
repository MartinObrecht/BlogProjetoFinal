using MediatR;

namespace BlogProjetoFinal.Api.Application.Handlers.Artigos.CriaArtigo
{
    public class CriaArtigoRequest : IRequest<CriaArtigoResponse>
    {
        public int CategoriaId { get; set; }
        public Guid UsuarioId { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAtualizacao { get; set; }
    }
}
