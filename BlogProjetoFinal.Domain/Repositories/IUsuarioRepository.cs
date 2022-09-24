using BlogProjetoFinal.Domain.Entities;

namespace BlogProjetoFinal.Domain.Repositories
{
    public interface IUsuarioRepository
    {
        Task<UsuarioEntity> ObterUsuario(Guid id);
        Task<List<UsuarioEntity>> ObterUsuarios();
        Task<UsuarioEntity> CriarUsuario(UsuarioEntity usuarioEntity);
    }
}
