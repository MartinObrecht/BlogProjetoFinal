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
        private readonly ILiquidRepository<UsuarioEntity, Guid> _repository;

        public CreateUsuarioCommandHandler(ILiquidRepository<UsuarioEntity, Guid> repository)
        {
            _repository = repository;
        }

        ///<inheritdoc/>        
        public async Task<Unit> Handle(CreateUsuarioCommand request, CancellationToken cancellationToken)
        {
            var usuario = new UsuarioEntity
            {
                Id = Guid.NewGuid(),
                Nome = request.Nome,
                NomeDeUsuario = request.NomeDeUsuario,
                Email = request.Email,
                Senha = request.Senha,
                DataAtualizacao = DateTime.Now,
                DataCriacao = DateTime.Now,
            };
            
            await _repository.AddAsync(usuario);

            return new Unit();
        }
    }
}
