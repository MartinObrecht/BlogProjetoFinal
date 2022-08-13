using Liquid.Repository;
using MediatR;
using BlogProjetoFinal.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace BlogProjetoFinal.Domain.Handlers.Usuario.Remove
{
    public class RemoveUsuarioCommandHandler : IRequestHandler<RemoveUsuarioCommand, RemoveUsuarioCommandResponse>
    {
        private readonly ILiquidRepository<UsuarioEntity, Guid> _repository;

        public RemoveUsuarioCommandHandler(ILiquidRepository<UsuarioEntity, Guid> repository)
        {
            _repository = repository;
        }

        ///<inheritdoc/>        
        public async Task<RemoveUsuarioCommandResponse> Handle(RemoveUsuarioCommand request, CancellationToken cancellationToken)
        {
            var data = await _repository.FindByIdAsync(request.Id);

            if (data != null)
            {
                await _repository.RemoveByIdAsync(request.Id);
                //await _mediator.Publish(new GenericEntityRemovedNotification<TEntity, TIdentifier>(entity));
            }

            return new RemoveUsuarioCommandResponse(data);
        }
    }
}
