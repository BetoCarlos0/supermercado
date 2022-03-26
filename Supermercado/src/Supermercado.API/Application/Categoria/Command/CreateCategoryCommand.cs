using FluentValidation.Results;
using MediatR;
using Supermercado.API.Application.Categoria.Validation;
using System.Text.Json.Serialization;

namespace Supermercado.API.Application.Categoria.Command
{
    public class CreateCategoryCommand : IRequest<bool>
    {
        public string Descricao { get; set; }

        [JsonIgnore]
        public ValidationResult Validation { get; }
        public CreateCategoryCommand(string descricao)
        {
            Descricao = descricao;
            var validator = new CreateCategoryCommandValidator();
            Validation = validator.Validate(this);
        }
    }
}
