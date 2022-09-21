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

        public async Task<List<Usuario>> ObterUsuarios()
        {
            var usuarios = new List<Usuario>();

            try
            {
                usuarios = DbContext.UsuarioEntity.AsEnumerable().ToList();

                foreach(var usuario in usuarios)
                {
                    usuario.CodigoRetorno = (int)HttpStatusCode.OK;
                }

            }
            catch (Exception ex)
            {
                usuarios.Add(new Usuario
                {
                    CodigoRetorno = (int)HttpStatusCode.InternalServerError,
                    MensagemRetorno = $"{MensagensRetornoFields.OcorreuErro}: {ex.Message}",
            });
            }

            return await Task.FromResult(usuarios);
        }

        public async Task<Usuario> ObterUsuario(Guid id)
        {
            var usuario = new Usuario();

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

        public async Task<Usuario> CriarUsuario(Usuario usuarioEntity)
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
