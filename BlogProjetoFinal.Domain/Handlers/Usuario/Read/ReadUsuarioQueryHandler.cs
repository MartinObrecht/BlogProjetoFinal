using Liquid.Repository;
using MediatR;
using BlogProjetoFinal.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace BlogProjetoFinal.Domain.Handlers.Usuario.Read
{
    public class ReadUsuarioQueryHandler : IRequestHandler<ReadUsuarioQuery, ReadUsuarioQueryResponse>
    {
        private readonly ILiquidRepository<UsuarioEntity, int> _repository;

        public ReadUsuarioQueryHandler(ILiquidRepository<UsuarioEntity, int> repository)
        {
            _repository = repository;
        }

        ///<inheritdoc/>        
        public async Task<ReadUsuarioQueryResponse> Handle(ReadUsuarioQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.FindByIdAsync(request.Id);

            return new ReadUsuarioQueryResponse(data);
        }
    }
}
