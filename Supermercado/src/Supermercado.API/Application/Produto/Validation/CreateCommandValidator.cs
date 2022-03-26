using FluentValidation;
using Supermercado.API.Application.Produto.Command;

namespace Supermercado.API.Application.Produto.Validation
{
    public class CreateCommandValidator : AbstractValidator<CreateCommand>
    {
        public CreateCommandValidator()
        {
            RuleFor(x => x.Descricao)
                .NotNull()
                .NotEmpty()
                .MaximumLength(300);


            RuleFor(x => x.IdCategorias)
                .Cascade(CascadeMode.Stop)
                .NotNull()
                .NotEmpty()
                .Must(x => x.Length > 0);
        }
    }
}
