using MediatR;
using System.Collections.Generic;


namespace Supermercado.API.Application.Produto.Query
{
    public class ListaProdutosQuery : IRequest<IEnumerable<Domain.Produto>>
    {

    }
}
