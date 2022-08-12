using MediatR;

namespace BlogProjetoFinal.Domain.Handlers.Artigo.List
{
    public class ListArtigoQuery : IRequest<ListArtigoQueryResponse>
    {
        public ListArtigoQuery()
        {

        }
    }
}
