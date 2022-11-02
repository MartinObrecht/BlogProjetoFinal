using BlogProjetoFinal.Api.Domain.Messages;
using BlogProjetoFinal.Api.Domain.Repositories;
using MediatR;
using System.Net;

namespace BlogProjetoFinal.Api.Application.Handlers.Artigos.ConsultaArtigos
{
    public class ConsultaArtigosHandler : IRequestHandler<ConsultaArtigosRequest, List<ConsultaArtigosResponse>>
    {
        private readonly IArtigoRepository _artigoRepository;

        public ConsultaArtigosHandler(IArtigoRepository artigoRepository)
        {
            _artigoRepository = artigoRepository;
        }

        public async Task<List<ConsultaArtigosResponse>> Handle(ConsultaArtigosRequest request, CancellationToken cancellationToken)
        {
            var response = new List<ConsultaArtigosResponse>();
            var artigos = _artigoRepository.ObterArtigos().Result;

            if (artigos.Count > 0)
            {
                foreach (var artigo in artigos)
                {
                    response.Add(new ConsultaArtigosResponse
                    {
                        CodigoRetorno = artigo.CodigoRetorno,
                        Titulo = artigo.Titulo,
                        Conteudo = artigo.Conteudo,
                        Categoria = artigo.Categoria.NomeCategoria,
                        NomeUsuario = artigo.Usuario.NomeDeUsuario,
                        MensagemRetorno = MensagensRetornoFields.Sucesso,
                    });
                }
            }

            return await Task.FromResult(response);

        }
    }
}
