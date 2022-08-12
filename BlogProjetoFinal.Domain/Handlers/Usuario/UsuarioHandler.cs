using Liquid.Repository;
using MediatR;
using BlogProjetoFinal.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace BlogProjetoFinal.Domain.Handlers.Usuario
{
    public class UsuarioHandler : IRequestHandler<UsuarioRequest, UsuarioResponse>
    {
        private readonly ILiquidRepository<UsuarioEntity, int> _repository;

        public UsuarioHandler(ILiquidRepository<UsuarioEntity, int> repository)
        {
            _repository = repository;
        }


        public async Task<UsuarioResponse> Handle(UsuarioRequest request, CancellationToken cancellationToken)
        {
            //TODO: implement handler operation.

            return new UsuarioResponse(request.Body);
        }
    }
}
