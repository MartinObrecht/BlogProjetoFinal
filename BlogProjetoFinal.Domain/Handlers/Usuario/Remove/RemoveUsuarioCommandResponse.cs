using BlogProjetoFinal.Domain.Entities;

namespace BlogProjetoFinal.Domain.Handlers.Usuario.Remove
{
    public class RemoveUsuarioCommandResponse
    {
        public UsuarioEntity Data { get; set; }

        public RemoveUsuarioCommandResponse(UsuarioEntity data)
        {
            Data = data;
        }
    }
}
