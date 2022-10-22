using EmployeeAuthCrud.Domain.Base;
using EmployeeAuthCrud.Domain.Entities;
using System.Threading.Tasks; 

namespace EmployeeAuthCrud.Domain
{
    public interface IUnitOfWork
    {


        
        IEmployeeRepository EmployeeRepository { get; }
        ICountryRepository CountryRepository { get; }
   

        Task<int> SaveChangesAsync();

        IRepository<T> AsyncRepository<T>() where T : Entity;
    }
}
