using MediatR;
using System;

namespace BlogProjetoFinal.Domain.Handlers.Usuario.Read
{
    public class ReadUsuarioQuery : IRequest<ReadUsuarioQueryResponse>
    {
        public Guid Id { get; set; }

        public ReadUsuarioQuery(Guid id)
        {
            Id = id;
        }
    }
}
