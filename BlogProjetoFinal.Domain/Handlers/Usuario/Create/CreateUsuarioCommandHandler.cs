using Liquid.Repository;
using MediatR;
using BlogProjetoFinal.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace BlogProjetoFinal.Domain.Handlers.Usuario.Create
{
    public class CreateUsuarioCommandHandler : IRequestHandler<CreateUsuarioCommand>
    {
        private readonly ILiquidRepository<UsuarioEntity, int> _repository;

        public CreateUsuarioCommandHandler(ILiquidRepository<UsuarioEntity, int> repository)
        {
            _repository = repository;
        }

        ///<inheritdoc/>        
        public async Task<Unit> Handle(CreateUsuarioCommand request, CancellationToken cancellationToken)
        {
            await _repository.AddAsync(request.Body);

            return new Unit();
        }
    }
}
