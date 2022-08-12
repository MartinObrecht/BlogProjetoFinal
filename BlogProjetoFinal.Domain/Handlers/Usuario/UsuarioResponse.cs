using BlogProjetoFinal.Domain.Entities;

namespace BlogProjetoFinal.Domain.Handlers.Usuario
{
    public class UsuarioResponse
    {
        public UsuarioEntity Data { get; set; }

        public UsuarioResponse(UsuarioEntity data)
        {
            Data = data;
        }
    }
}
