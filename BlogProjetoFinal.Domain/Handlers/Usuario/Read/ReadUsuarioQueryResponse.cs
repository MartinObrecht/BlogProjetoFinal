using BlogProjetoFinal.Domain.Entities;

namespace BlogProjetoFinal.Domain.Handlers.Usuario.Read
{
    public class ReadUsuarioQueryResponse
    {
        public UsuarioEntity Data { get; set; }

        public ReadUsuarioQueryResponse(UsuarioEntity data)
        {
            Data = data;
        }
    }
}
