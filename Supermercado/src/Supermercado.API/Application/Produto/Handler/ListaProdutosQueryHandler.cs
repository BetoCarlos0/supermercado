using MediatR;
using Supermercado.API.Application.Produto.Query;
using Supermercado.Infrastructure.Data.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Supermercado.API.Application.Produto.Handler
{
    public class ListaProdutosQueryHandler : IRequestHandler<ListaProdutosQuery, IEnumerable<Domain.Produto>>
    {
        private readonly IGenericRepository<Domain.Produto> _produtoRepository;

        public ListaProdutosQueryHandler(IGenericRepository<Domain.Produto> produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<IEnumerable<Domain.Produto>> Handle(ListaProdutosQuery request, CancellationToken cancellationToken)
        {
            return await _produtoRepository.GetAllAsync(
                    noTracking: false,
                    includeProperties: "Categorias,Estoque",
                    cancellationToken: cancellationToken
                ).ConfigureAwait(false);
        }
    }
}
