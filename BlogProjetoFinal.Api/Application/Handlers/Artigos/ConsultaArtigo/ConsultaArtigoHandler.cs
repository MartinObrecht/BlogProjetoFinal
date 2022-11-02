using BlogProjetoFinal.Api.Domain.Entities;
using BlogProjetoFinal.Api.Domain.Messages;
using BlogProjetoFinal.Api.Domain.Repositories;
using MediatR;

namespace BlogProjetoFinal.Api.Application.Handlers.Artigos.ConsultaArtigo
{
    public class ConsultaArtigoHandler : IRequestHandler<ConsultaArtigoRequest, ConsultaArtigoResponse>
    {
        private readonly IArtigoRepository _artigoRepository;

        public ConsultaArtigoHandler(IArtigoRepository artigoRepository)
        {
            _artigoRepository = artigoRepository;
        }
        public async Task<ConsultaArtigoResponse> Handle(ConsultaArtigoRequest request, CancellationToken cancellationToken)
        {
            var artigo = new Artigo();
            var response = new ConsultaArtigoResponse();

            artigo = await _artigoRepository.ObterArtigo(request.Id);

            response.NomeUsuario = artigo.Usuario.NomeDeUsuario;
            response.Conteudo = artigo.Conteudo;
            response.Titulo = artigo.Titulo;
            response.Categoria = artigo.Categoria.NomeCategoria;
            response.MensagemRetorno = MensagensRetornoFields.Sucesso;
            response.CodigoRetorno = artigo.CodigoRetorno;


            return await Task.FromResult(response);
        }
    }
}