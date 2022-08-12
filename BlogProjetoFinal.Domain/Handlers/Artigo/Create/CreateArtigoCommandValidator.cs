using FluentValidation;

namespace BlogProjetoFinal.Domain.Handlers.Artigo.Create
{
    public class CreateArtigoCommandValidator : AbstractValidator<CreateArtigoCommand>
    {
        public CreateArtigoCommandValidator()
        {
            RuleFor(request => request.Body.Id).NotEmpty().NotNull();
        }
    }
}
