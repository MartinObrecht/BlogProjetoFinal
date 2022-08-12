using MediatR;
using System;

namespace BlogProjetoFinal.Domain.Handlers.Usuario.Read
{
    public class ReadUsuarioQuery : IRequest<ReadUsuarioQueryResponse>
    {
        public int Id { get; set; }

        public ReadUsuarioQuery(int id)
        {
            Id = id;
        }
    }
}
