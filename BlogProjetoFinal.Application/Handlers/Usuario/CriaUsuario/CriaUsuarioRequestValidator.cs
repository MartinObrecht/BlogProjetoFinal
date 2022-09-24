 using FluentValidation;

namespace BlogProjetoFinal.Application.Handlers.Usuario.CriaUsuario
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
