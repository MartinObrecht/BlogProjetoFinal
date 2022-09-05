using BlogProjetoFinal.Domain.Entities;
using BlogProjetoFinal.Domain.Messages;
using BlogProjetoFinal.Domain.Repositories;
using System.Net;

namespace BlogProjetoFinal.Data.Repositories.Db
{
    public class UsuarioRepository : BaseRepository, IUsuarioRepository
    {
        public UsuarioRepository(BlogProjetoFinalDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<UsuarioEntity>> ObterUsuarios()
        {
            var usuarios = new List<UsuarioEntity>();

            try
            {
                usuarios = DbContext.UsuarioEntity.AsEnumerable().ToList();

            }
            catch (Exception ex)
            {

            }

            return await Task.FromResult(usuarios);
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
            }

            return await Task.FromResult(usuario);
        }

        public async Task<UsuarioEntity> CriarUsuario(UsuarioEntity usuarioEntity)
        {
            try
            {
                var result = await DbContext.UsuarioEntity.AddAsync(usuarioEntity);
                await DbContext.SaveChangesAsync();

                usuarioEntity.MensagemRetorno = MensagensRetornoFields.UsuarioCriado;
                usuarioEntity.CodigoRetorno = (int)HttpStatusCode.Created;

            }
            catch (Exception ex)
            {
                usuarioEntity.MensagemRetorno = $"{MensagensRetornoFields.OcorreuErro}: {ex.Message}";
                usuarioEntity.CodigoRetorno = (int)HttpStatusCode.InternalServerError;
            }

            return await Task.FromResult(usuarioEntity);
        }
    }
}
