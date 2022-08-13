using Liquid.Repository;
using MediatR;
using BlogProjetoFinal.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace BlogProjetoFinal.Domain.Handlers.Usuario.List
{
    public class ListUsuarioQueryHandler : IRequestHandler<ListUsuarioQuery, ListUsuarioQueryResponse>
    {
        private readonly ILiquidRepository<UsuarioEntity, Guid> _repository;

        public ListUsuarioQueryHandler(ILiquidRepository<UsuarioEntity, Guid> repository)
        {
            _repository = repository;
        }

        ///<inheritdoc/>        
        public async Task<ListUsuarioQueryResponse> Handle(ListUsuarioQuery request, CancellationToken cancellationToken)
        {
            var data = await _repository.FindAllAsync();

            return new ListUsuarioQueryResponse(data);
        }
    }
}
