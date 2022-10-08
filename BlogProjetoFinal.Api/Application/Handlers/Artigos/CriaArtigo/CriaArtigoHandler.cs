using BlogProjetoFinal.Api.Domain.Entities;
using BlogProjetoFinal.Api.Domain.Enums;
using BlogProjetoFinal.Api.Domain.Repositories;
using MediatR;

namespace BlogProjetoFinal.Api.Application.Handlers.Artigos.CriaArtigo
{
    public class CriaArtigoHandler : IRequestHandler<CriaArtigoRequest, CriaArtigoResponse>
    {
        private readonly IArtigoRepository _artigoRepository;

        public CriaArtigoHandler(IArtigoRepository artigoRepository)
        {
            _artigoRepository = artigoRepository;
        }

        public async Task<CriaArtigoResponse> Handle(CriaArtigoRequest request, CancellationToken cancellationToken)
        {
            Artigo novoArtigo = new Artigo {
                CategoriaId = request.CategoriaId, 
                Titulo = request.Titulo, 
                UsuarioId = request.UsuarioId,
                Conteudo = request.Conteudo,
                DataAtualizacao = DateTime.Now,
                DataCriacao = DateTime.Now,
            };

            var artigoCriado = await _artigoRepository.CriaArtigo(novoArtigo);

            return await Task.FromResult(new CriaArtigoResponse { 
                CodigoRetorno = artigoCriado.CodigoRetorno, 
                Conteudo = artigoCriado.Conteudo, 
                MensagemRetorno = artigoCriado.MensagemRetorno, 
                Titulo = artigoCriado.Titulo}
            );
        }
    }
}
