using BlogProjetoFinal.Api.Domain.Messages;
using BlogProjetoFinal.Api.Domain.Repositories;
using MediatR;

namespace BlogProjetoFinal.Api.Application.Handlers.Artigos.ConsultaArtigosPorUsuario
{
    public class ConsultaArtigosPorUsuarioHandler : IRequestHandler<ConsultaArtigosPorUsuarioRequest, List<ConsultaArtigosPorUsuarioResponse>>
    {
        private readonly IArtigoRepository _artigoRepository;

        public ConsultaArtigosPorUsuarioHandler(IArtigoRepository artigoRepository)
        {
            _artigoRepository = artigoRepository;
        }
        public async Task<List<ConsultaArtigosPorUsuarioResponse>> Handle(ConsultaArtigosPorUsuarioRequest request, CancellationToken cancellationToken)
        {
            var response = new List<ConsultaArtigosPorUsuarioResponse>();
            var artigos = _artigoRepository.ObterArtigosPorUsuario(request.Id).Result;

            if (artigos.Count > 0)
            {
                foreach (var artigo in artigos)
                {
                    response.Add(new ConsultaArtigosPorUsuarioResponse
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
