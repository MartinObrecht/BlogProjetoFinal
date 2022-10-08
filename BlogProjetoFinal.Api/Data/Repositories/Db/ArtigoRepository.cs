using BlogProjetoFinal.Api.Domain.Entities;
using BlogProjetoFinal.Api.Domain.Messages;
using BlogProjetoFinal.Api.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace BlogProjetoFinal.Api.Data.Repositories.Db
{
    public class ArtigoRepository : BaseRepository, IArtigoRepository
    {
        public ArtigoRepository(BlogProjetoFinalDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<Artigo> AtualizarArtigo(Artigo artigoAtualizado)
        {
            try
            {
                DbContext.ArtigoEntity.Update(artigoAtualizado);

                await DbContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw;
            }
            return await Task.FromResult(artigoAtualizado);
        }

        public async Task<Artigo> CriaArtigo(Artigo artigo)
        {
            try
            {
                var result = await DbContext.ArtigoEntity.AddAsync(artigo);
                artigo.MensagemRetorno = MensagensRetornoFields.ArtigoCriado;
                artigo.CodigoRetorno = (int)HttpStatusCode.Created;
                await DbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                artigo.MensagemRetorno = $"{MensagensRetornoFields.OcorreuErro}: {ex.Message}";
                artigo.CodigoRetorno = (int)HttpStatusCode.InternalServerError;
            }
            return await Task.FromResult(artigo);
        }

        public async Task<Artigo> DeletarArtigo(Artigo artigo)
        {
            try
            {
                DbContext.ArtigoEntity.Remove(artigo);

                await DbContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw;
            }
            return await Task.FromResult(artigo);
        }

        public async Task<Artigo> ObterArtigo(int id)
        {
            Artigo artigo;

            try
            {
                artigo = await DbContext.ArtigoEntity
                    .AsNoTracking()
                    .Include(u => u.Usuario)
                    .Include(c => c.Categoria)
                    .Where(x => x.Id.Equals(id))
                    .FirstOrDefaultAsync();

                if (!(artigo == null))
                {
                    artigo.CodigoRetorno = (int)HttpStatusCode.OK;
                    artigo.MensagemRetorno = MensagensRetornoFields.Sucesso;
                }
                else
                {
                    artigo.CodigoRetorno = (int)HttpStatusCode.NotFound;
                    artigo.MensagemRetorno = MensagensRetornoFields.UsuarioNaoEncontrado;
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return await Task.FromResult(artigo);
        }

        public async Task<List<Artigo>> ObterArtigos()
        {
            var artigos = new List<Artigo>();

            try
            {
                artigos = DbContext.ArtigoEntity.AsNoTracking()
                    .Include(c => c.Categoria)
                    .Include(u => u.Usuario)
                    .AsEnumerable()
                    .ToList();


                foreach (var artigo in artigos)
                {
                    artigo.CodigoRetorno = (int)HttpStatusCode.OK;
                }

            }
            catch (Exception ex)
            {
                artigos.Add(new Artigo
                {
                    CodigoRetorno = (int)HttpStatusCode.InternalServerError,
                    MensagemRetorno = $"{MensagensRetornoFields.OcorreuErro}: {ex.Message}",
                });
            }

            return await Task.FromResult(artigos);
        }

        public async Task<List<Artigo>> ObterArtigosPorCategoria(int categoriaId)
        {
            var artigos = new List<Artigo>();

            try
            {
                artigos = DbContext.ArtigoEntity.AsNoTracking()
                    .Include(c => c.Categoria)
                    .Where(c => c.CategoriaId == categoriaId)
                    .Include(u => u.Usuario)
                    .AsEnumerable()
                    .ToList();


                foreach (var artigo in artigos)
                {
                    artigo.CodigoRetorno = (int)HttpStatusCode.OK;
                }

            }
            catch (Exception ex)
            {
                artigos.Add(new Artigo
                {
                    CodigoRetorno = (int)HttpStatusCode.InternalServerError,
                    MensagemRetorno = $"{MensagensRetornoFields.OcorreuErro}: {ex.Message}",
                });
            }

            return await Task.FromResult(artigos);
        }

        public async Task<List<Artigo>> ObterArtigosPorUsuario(Guid usuarioId)
        {
            var artigos = new List<Artigo>();

            try
            {
                artigos = DbContext.ArtigoEntity.AsNoTracking()
                    .Include(c => c.Categoria)
                    .Where(u => u.UsuarioId == usuarioId)
                    .Include(u => u.Usuario)
                    .AsEnumerable()
                    .ToList();


                foreach (var artigo in artigos)
                {
                    artigo.CodigoRetorno = (int)HttpStatusCode.OK;
                }

            }
            catch (Exception ex)
            {
                artigos.Add(new Artigo
                {
                    CodigoRetorno = (int)HttpStatusCode.InternalServerError,
                    MensagemRetorno = $"{MensagensRetornoFields.OcorreuErro}: {ex.Message}",
                });
            }

            return await Task.FromResult(artigos);
        }
    }
}
