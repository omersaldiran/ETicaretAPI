using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.Customer;

public class CustomerWriteRepository : WriteRepository<Domain.Entities.Customer>, ICustomerWriteRepository
{
    public CustomerWriteRepository(ETicaretAPIDbContext context) : base(context)
    {
    }
}