using BlogProjetoFinal.Api.Domain.Entities;
using BlogProjetoFinal.Api.Domain.Messages;
using BlogProjetoFinal.Api.Domain.Repositories;
using System.Net;

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
                    usuario.CodigoRetorno = (int)HttpStatusCode.OK;
                    usuario.MensagemRetorno = MensagensRetornoFields.Sucesso;
                    usuario.NomeDeUsuario = resultQuery.NomeDeUsuario;
                    usuario.Email = resultQuery.Email;
                }
                else
                {
                    usuario.CodigoRetorno = (int)HttpStatusCode.NotFound;
                    usuario.MensagemRetorno = MensagensRetornoFields.UsuarioNaoEncontrado;
                }
            }
            catch (Exception ex)
            {
                usuario.CodigoRetorno = (int)HttpStatusCode.InternalServerError;
                usuario.MensagemRetorno = $"{MensagensRetornoFields.OcorreuErro}: {ex.Message}";
                throw new Exception(ex.Message);
            }

            return await Task.FromResult(usuario);
        }
    }
}
