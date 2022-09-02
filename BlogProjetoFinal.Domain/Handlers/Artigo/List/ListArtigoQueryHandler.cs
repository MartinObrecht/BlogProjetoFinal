using Liquid.Repository;
using MediatR;
using BlogProjetoFinal.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace BlogProjetoFinal.Domain.Handlers.Artigo.List
{
    public class ListArtigoQueryHandler : IRequestHandler<ListArtigoQuery, ListArtigoQueryResponse>
    {
        private readonly ILiquidRepository<ArtigoEntity, int> _repository;

        public ListArtigoQueryHandler(ILiquidRepository<ArtigoEntity, int> repository)
        {
            _repository = repository;
        }

        ///<inheritdoc/>        
        public async Task<ListArtigoQueryResponse> Handle(ListArtigoQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.FindAllAsync();

            return new ListArtigoQueryResponse(data);
        }
    }
}
