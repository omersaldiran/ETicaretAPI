using ETicaretAPI.Application.Repositories.Order;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.Order;

public class OrderReadRepository : ReadRepository<Domain.Entities.Order>, IOrderReadRepository
{
    public OrderReadRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}