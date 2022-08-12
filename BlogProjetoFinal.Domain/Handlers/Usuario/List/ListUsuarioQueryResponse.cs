using BlogProjetoFinal.Domain.Entities;
using System.Collections.Generic;

namespace BlogProjetoFinal.Domain.Handlers.Usuario.List
{
    public class ListUsuarioQueryResponse
    {
        public IEnumerable<UsuarioEntity> Data { get; set; }

        public ListUsuarioQueryResponse(IEnumerable<UsuarioEntity> data)
        {
            Data = data;
        }
    }
}
