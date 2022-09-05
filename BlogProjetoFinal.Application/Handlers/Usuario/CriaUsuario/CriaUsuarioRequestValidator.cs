using FluentValidation;

namespace BlogProjetoFinal.Application.Handlers.Usuario.CriaUsuario
{
    public class CriaUsuarioRequestValidator : AbstractValidator<CriaUsuarioRequest>
    {
        public CriaUsuarioRequestValidator()
        {
            RuleFor(request => request.NovoUsuario.Nome).NotEmpty().NotNull();
            RuleFor(request => request.NovoUsuario.NomeDeUsuario).NotEmpty().NotNull();
            RuleFor(request => request.NovoUsuario.Senha).NotEmpty().NotNull();
            RuleFor(request => request.NovoUsuario.Email).NotEmpty().NotNull();
        }
    }
}
