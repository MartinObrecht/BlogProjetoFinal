using FluentValidation;

namespace BlogProjetoFinal.Domain.Handlers.Artigo
{
    public class ArtigoRequestValidator : AbstractValidator<ArtigoRequest>
    {
        public ArtigoRequestValidator()
        {
            RuleFor(request => request.Body.Id).NotEmpty().NotNull();
        }
    }
}
