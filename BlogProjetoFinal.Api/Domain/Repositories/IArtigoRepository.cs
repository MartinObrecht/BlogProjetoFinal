using BlogProjetoFinal.Api.Domain.Entities;

namespace BlogProjetoFinal.Api.Domain.Repositories
{
    public interface IArtigoRepository
    {
        Task<Artigo> CriaArtigo(Artigo artigo);
        Task<Artigo> ObterArtigo(int id);
        Task<List<Artigo>> ObterArtigos();
        Task<List<Artigo>> ObterArtigosPorUsuario(Guid usuarioId);
        Task<List<Artigo>> ObterArtigosPorCategoria(int categoriaId);
        Task<Artigo> AtualizarArtigo(Artigo artigo);
        Task<Artigo> DeletarArtigo(Artigo artigo);

    }
}
