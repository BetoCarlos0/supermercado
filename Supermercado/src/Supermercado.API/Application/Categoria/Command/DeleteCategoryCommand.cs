using MediatR;

namespace Supermercado.API.Application.Categoria.Command
{
    public class DeleteCategoryCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
