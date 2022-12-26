using ETicaretAPI.Application.Repositories.Order;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.Order;

public class OrderWriteRepository : WriteRepository<Domain.Entities.Order>, IOrderWriteRepository
{
    public OrderWriteRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}