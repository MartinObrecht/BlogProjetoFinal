 using FluentValidation;

namespace BlogProjetoFinal.Api.Application.Handlers.Usuarios.CriaUsuario
{
    public class CriaUsuarioRequestValidator : AbstractValidator<CriaUsuarioRequest>
    {
        public CriaUsuarioRequestValidator()
        {
            RuleFor(request => request.Nome).NotEmpty().NotNull();
            RuleFor(request => request.NomeDeUsuario).NotEmpty().NotNull();
            RuleFor(request => request.Senha).NotEmpty().NotNull();
            RuleFor(request => request.Email).NotEmpty().NotNull();
        }
    }
}
