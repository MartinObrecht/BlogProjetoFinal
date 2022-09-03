using Liquid.Repository;
using MediatR;
using BlogProjetoFinal.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace BlogProjetoFinal.Domain.Handlers.Usuario.Update
{
    public class UpdateUsuarioCommandHandler : IRequestHandler<UpdateUsuarioCommand, UpdateUsuarioCommandResponse>
    {
        private readonly ILiquidRepository<UsuarioEntity, Guid> _repository;

        public UpdateUsuarioCommandHandler(ILiquidRepository<UsuarioEntity, Guid> repository)
        {
            _repository = repository;
        }


        public async Task<UpdateUsuarioCommandResponse> Handle(UpdateUsuarioCommand request, CancellationToken cancellationToken)
        {
            var data = await _repository.FindByIdAsync(request.Id);

            if (data != null)
            {
                data.Senha = request.Usuario.Senha;
                data.DataAtualizacao = DateTime.Now;
                data.Email = request.Usuario.Email;
                data.Nome = request.Usuario.Nome;

                await _repository.UpdateAsync(data);
            }

            return new UpdateUsuarioCommandResponse(data.Nome, data.NomeDeUsuario, data.Email);
        }
    }
}
