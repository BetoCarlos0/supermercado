using MediatR;

namespace Supermercado.API.Application.Categoria.Command
{
    public class UpdateCategoryCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
