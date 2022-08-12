using MediatR;

namespace BlogProjetoFinal.Domain.Handlers.Usuario.List
{
    public class ListUsuarioQuery : IRequest<ListUsuarioQueryResponse>
    {
        public ListUsuarioQuery()
        {

        }
    }
}
