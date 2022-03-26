using MediatR;
using Supermercado.API.Application.Categoria.Query;
using Supermercado.Infrastructure.Data.Contract;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Supermercado.API.Application.Categoria.Handler
{
    public class GetAllCategoriesQueryHandler : IRequestHandler<GetAllCategoriesQuery, IEnumerable<Domain.Categoria>>
    {
        private readonly IGenericRepository<Domain.Categoria> _categoriaRepository;

        public GetAllCategoriesQueryHandler(IGenericRepository<Domain.Categoria> categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public async Task<IEnumerable<Domain.Categoria>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            return await _categoriaRepository.GetAllAsync(
                noTracking: true,
                cancellationToken: cancellationToken
                ).ConfigureAwait(false);
        }
    }
}
