using BlogProjetoFinal.Api.Domain.Entities;

namespace BlogProjetoFinal.Api.Domain.Repositories
{
    public interface IUsuarioRepository
    {
        Task<UsuarioEntity> ObterUsuario(Guid id);
    }
}
