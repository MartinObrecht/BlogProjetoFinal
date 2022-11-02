using BlogProjetoFinal.Api.Domain.Messages;
using BlogProjetoFinal.Api.Domain.Repositories;
using MediatR;
using System.Net;

namespace BlogProjetoFinal.Api.Application.Handlers.Artigos.AtualizarArtigo
{
    public class AtualizarArtigoHandler : IRequestHandler<AtualizarArtigoRequest, AtualizarArtigoResponse>
    {
        private readonly IArtigoRepository _artigoRepository;

        public AtualizarArtigoHandler(IArtigoRepository artigoRepository)
        {
            _artigoRepository = artigoRepository;
        }

        public async Task<AtualizarArtigoResponse> Handle(AtualizarArtigoRequest request, CancellationToken cancellationToken)
        {
            var artigo = _artigoRepository.ObterArtigo(request.Id).Result;

            artigo.Titulo = request.Titulo;
            artigo.Conteudo = request.Conteudo;
            artigo.DataAtualizacao = request.DataAtualizacao;
            artigo.MensagemRetorno = MensagensRetornoFields.ArtigoAtualizado;
            artigo.CodigoRetorno = (int)HttpStatusCode.OK;

            await _artigoRepository.AtualizarArtigo(artigo);

            return await Task.FromResult(new AtualizarArtigoResponse
            {
                Id = request.Id,
                MensagemRetorno = artigo.MensagemRetorno,
                CodigoRetorno = artigo.CodigoRetorno,
            });
        }
    }
}
