using FluentValidation;

namespace BlogProjetoFinal.Domain.Handlers.Usuario.Create
{
    public class CreateUsuarioCommandValidator : AbstractValidator<CreateUsuarioCommand>
    {
        public CreateUsuarioCommandValidator()
        {
            RuleFor(request => request.Nome).NotEmpty().NotNull();
            RuleFor(request => request.Email).NotEmpty().NotNull();
            RuleFor(request => request.NomeDeUsuario).NotEmpty().NotNull();
            RuleFor(request => request.Senha).NotEmpty().NotNull();
        }
    }
}
