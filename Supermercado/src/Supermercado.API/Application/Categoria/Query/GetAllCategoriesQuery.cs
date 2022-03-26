using MediatR;
using System.Collections.Generic;

namespace Supermercado.API.Application.Categoria.Query
{
    public class GetAllCategoriesQuery : IRequest<IEnumerable<Domain.Categoria>>
    {
    }
}
