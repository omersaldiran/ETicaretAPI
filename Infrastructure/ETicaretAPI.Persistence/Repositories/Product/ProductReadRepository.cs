using ETicaretAPI.Application.Repositories.Product;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.Product;

public class ProductReadRepository : ReadRepository<Domain.Entities.Product>, IProductReadRepository
{
    public ProductReadRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}