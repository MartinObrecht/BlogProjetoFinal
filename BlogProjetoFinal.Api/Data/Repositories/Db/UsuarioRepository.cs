using BlogProjetoFinal.Api.Domain.Entities;
using BlogProjetoFinal.Api.Domain.Repositories;

namespace BlogProjetoFinal.Api.Data.Repositories.Db
{
    public class UsuarioRepository : BaseRepository, IUsuarioRepository
    {
        public UsuarioRepository(BlogProjetoFinalDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<UsuarioEntity> ObterUsuario(Guid id)
        {
            var usuario = new UsuarioEntity();

            try
            {
                var resultQuery = DbContext.UsuarioEntity.FindAsync(id).Result;

                if (!(resultQuery == null))
                {
                    usuario.CodigoRetorno = 200;
                    usuario.NomeDeUsuario = resultQuery.NomeDeUsuario;
                    usuario.Email = resultQuery.Email;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return await Task.FromResult(usuario);
        }
    }
}
