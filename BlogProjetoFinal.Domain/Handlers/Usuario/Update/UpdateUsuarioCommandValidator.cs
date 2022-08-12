using FluentValidation;

namespace BlogProjetoFinal.Domain.Handlers.Usuario.Update
{
    public class UpdateUsuarioCommandValidator : AbstractValidator<UpdateUsuarioCommand>
    {
        public UpdateUsuarioCommandValidator()
        {
            RuleFor(request => request.Body.Id).NotEmpty().NotNull();
        }
    }
}
