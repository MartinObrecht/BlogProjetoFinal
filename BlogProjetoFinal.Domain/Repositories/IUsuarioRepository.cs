using BlogProjetoFinal.Domain.Entities;

namespace BlogProjetoFinal.Domain.Repositories
{
    public interface IUsuarioRepository
    {
        Task<UsuarioEntity> ObterUsuario(Guid id);
    }
}
