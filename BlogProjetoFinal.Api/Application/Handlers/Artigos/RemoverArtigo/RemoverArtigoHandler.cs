using BlogProjetoFinal.Api.Domain.Messages;
using BlogProjetoFinal.Api.Domain.Repositories;
using MediatR;
using System.Net;

namespace BlogProjetoFinal.Api.Application.Handlers.Artigos.RemoverArtigo
{
    public class RemoverArtigoHandler : IRequestHandler<RemoverArtigoRequest, RemoverArtigoResponse>
    {
        private readonly IArtigoRepository _artigoRepository;

        public RemoverArtigoHandler(IArtigoRepository artigoRepository)
        {
            _artigoRepository = artigoRepository;
        }
        public async Task<RemoverArtigoResponse> Handle(RemoverArtigoRequest request, CancellationToken cancellationToken)
        {
            var artigo = _artigoRepository.ObterArtigo(request.Id).Result;

            await _artigoRepository.DeletarArtigo(artigo);

            return await Task.FromResult(new RemoverArtigoResponse
            {
                MensagemRetorno = MensagensRetornoFields.ArtigoRemovido,
                CodigoRetorno = (int)HttpStatusCode.OK
            });
        }
    }
}
