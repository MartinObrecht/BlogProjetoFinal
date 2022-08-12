using BlogProjetoFinal.Domain.Entities;
using Liquid.Repository;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BlogProjetoFinal.Domain.Handlers.Artigo
{
    public class ArtigoHandler : IRequestHandler<ArtigoRequest, ArtigoResponse>
    {
        private readonly ILiquidRepository<ArtigoEntity, int> _repository;

        public ArtigoHandler(ILiquidRepository<ArtigoEntity, int> repository)
        {
            _repository = repository;
        }


        public async Task<ArtigoResponse> Handle(ArtigoRequest request, CancellationToken cancellationToken)
        {
            //TODO: implement handler operation.

            return new ArtigoResponse(request.Body);
        }
    }
}
