using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EmployeeAuthCrud.Infrastructure
{
    public class EmployeeAuthCrudDBContextFactory : IDesignTimeDbContextFactory<EmployeeAuthCrudDBContext>
    {
        public EmployeeAuthCrudDBContext CreateDbContext(string[] args)
        { 
            var connectionString = "Data Source=localhost;Initial Catalog=EmployeeAuthCrud;Persist Security Info=True;User ID=sa;Password=sa"; 
            return new EmployeeAuthCrudDBContext(connectionString);
        }
    }
}
