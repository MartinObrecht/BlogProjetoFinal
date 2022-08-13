using Liquid.Repository;
using MediatR;
using BlogProjetoFinal.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace BlogProjetoFinal.Domain.Handlers.Artigo.Create
{
    public class CreateArtigoCommandHandler : IRequestHandler<CreateArtigoCommand>
    {
        private readonly ILiquidRepository<ArtigoEntity, Guid> _repository;

        public CreateArtigoCommandHandler(ILiquidRepository<ArtigoEntity, Guid> repository)
        {
            _repository = repository;
        }

        ///<inheritdoc/>        
        public async Task<Unit> Handle(CreateArtigoCommand request, CancellationToken cancellationToken)
        {
            await _repository.AddAsync(request.Body);

            return new Unit();
        }
    }
}
