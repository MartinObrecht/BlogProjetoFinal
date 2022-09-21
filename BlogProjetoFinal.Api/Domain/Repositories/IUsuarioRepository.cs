using BlogProjetoFinal.Api.Domain.Entities;

namespace BlogProjetoFinal.Api.Domain.Repositories
{
    public interface IUsuarioRepository
    {
        Task<Usuario> ObterUsuario(Guid id);
        Task<List<Usuario>> ObterUsuarios();
        Task<Usuario> CriarUsuario(Usuario usuarioEntity);
    }
}
