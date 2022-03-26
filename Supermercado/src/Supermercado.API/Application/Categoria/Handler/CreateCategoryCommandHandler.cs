using MediatR;
using Supermercado.API.Application.Categoria.Command;
using Supermercado.Infrastructure.Data.Contract;
using System.Threading;
using System.Threading.Tasks;

namespace Supermercado.API.Application.Categoria.Handler
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, bool>
    {
        private readonly IGenericRepository<Domain.Categoria> _categoriaRepository;

        public CreateCategoryCommandHandler(IGenericRepository<Domain.Categoria> categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public async Task<bool> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            if (!request.Validation.IsValid)
                return false;

            var categoria = new Domain.Categoria
            {
                Descricao = request.Descricao
            };

            await _categoriaRepository.AddAsync(categoria, cancellationToken)
                .ConfigureAwait(false);

            return await _categoriaRepository.CommitAsync(cancellationToken)
                .ConfigureAwait(false);
        }
    }
}
