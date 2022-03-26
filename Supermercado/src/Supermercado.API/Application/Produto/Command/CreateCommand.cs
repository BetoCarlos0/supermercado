using FluentValidation.Results;
using MediatR;
using Supermercado.API.Application.Produto.Validation;
using System.Text.Json.Serialization;


namespace Supermercado.API.Application.Produto.Command
{
    public class CreateCommand : IRequest<bool>
    {
        private ValidationResult validation;
        public CreateCommand(string descricao, int[] idCategorias)
        {
            Descricao = descricao;
            IdCategorias = idCategorias;

            var validator = new CreateCommandValidator();
            validation = validator.Validate(this);
        }
        public string Descricao { get; set; }
        public int[] IdCategorias { get; set; }
        [JsonIgnore]
        public ValidationResult Validation => validation;
    }      
}
