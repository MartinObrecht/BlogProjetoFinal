using Liquid.Repository;
using MediatR;
using BlogProjetoFinal.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace BlogProjetoFinal.Domain.Handlers.Artigo.Remove
{
    public class RemoveArtigoCommandHandler : IRequestHandler<RemoveArtigoCommand, RemoveArtigoCommandResponse>
    {
        private readonly ILiquidRepository<ArtigoEntity, Guid> _repository;

        public RemoveArtigoCommandHandler(ILiquidRepository<ArtigoEntity, Guid> repository)
        {
            _repository = repository;
        }

        ///<inheritdoc/>        
        public async Task<RemoveArtigoCommandResponse> Handle(RemoveArtigoCommand request, CancellationToken cancellationToken)
        {
            var data = await _repository.FindByIdAsync(request.Id);

            if (data != null)
            {
                await _repository.RemoveByIdAsync(request.Id);
            }

            return new RemoveArtigoCommandResponse(data);
        }
    }
}
