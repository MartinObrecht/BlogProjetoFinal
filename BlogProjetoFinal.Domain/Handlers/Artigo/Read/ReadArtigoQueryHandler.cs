using Liquid.Repository;
using MediatR;
using BlogProjetoFinal.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace BlogProjetoFinal.Domain.Handlers.Artigo.Read
{
    public class ReadArtigoQueryHandler : IRequestHandler<ReadArtigoQuery, ReadArtigoQueryResponse>
    {
        private readonly ILiquidRepository<ArtigoEntity, Guid> _repository;

        public ReadArtigoQueryHandler(ILiquidRepository<ArtigoEntity, Guid> repository)
        {
            _repository = repository;
        }

        ///<inheritdoc/>        
        public async Task<ReadArtigoQueryResponse> Handle(ReadArtigoQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.FindByIdAsync(request.Id);

            return new ReadArtigoQueryResponse(data);
        }
    }
}
