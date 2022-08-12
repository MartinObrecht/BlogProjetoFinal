using BlogProjetoFinal.Domain.Entities;

namespace BlogProjetoFinal.Domain.Handlers.Usuario.Update
{
    public class UpdateUsuarioCommandResponse
    {
        public UsuarioEntity Data { get; set; }

        public UpdateUsuarioCommandResponse(UsuarioEntity data)
        {
            Data = data;
        }
    }
}
