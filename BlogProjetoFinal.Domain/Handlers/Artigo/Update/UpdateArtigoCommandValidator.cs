using FluentValidation;

namespace BlogProjetoFinal.Domain.Handlers.Artigo.Update
{
    public class UpdateArtigoCommandValidator : AbstractValidator<UpdateArtigoCommand>
    {
        public UpdateArtigoCommandValidator()
        {
            RuleFor(request => request.Body.Id).NotEmpty().NotNull();
        }
    }
}
