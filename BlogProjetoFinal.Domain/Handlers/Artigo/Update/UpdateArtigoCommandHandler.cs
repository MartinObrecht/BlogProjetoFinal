using Liquid.Repository;
using MediatR;
using BlogProjetoFinal.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace BlogProjetoFinal.Domain.Handlers.Artigo.Update
{
    public class UpdateArtigoCommandHandler : IRequestHandler<UpdateArtigoCommand, UpdateArtigoCommandResponse>
    {
        private readonly ILiquidRepository<ArtigoEntity, int> _repository;

        public UpdateArtigoCommandHandler(ILiquidRepository<ArtigoEntity, int> repository)
        {
            _repository = repository;
        }


        public async Task<UpdateArtigoCommandResponse> Handle(UpdateArtigoCommand request, CancellationToken cancellationToken)
        {
            var data = await _repository.FindByIdAsync(request.Body.Id);

            if (data != null)
            {
                await _repository.UpdateAsync(request.Body);
            }

            return new UpdateArtigoCommandResponse(request.Body);
        }
    }
}
