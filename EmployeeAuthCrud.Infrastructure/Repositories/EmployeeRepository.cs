using EmployeeAuthCrud.Domain.Entities;
 

namespace EmployeeAuthCrud.Infrastructure.Repositories
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(EmployeeAuthCrudDBContext dbContext) : base(dbContext)
        {
        }
    }
}
