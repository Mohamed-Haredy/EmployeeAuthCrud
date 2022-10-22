using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EmployeeAuthCrud.Domain.Entities;

namespace EmployeeAuthCrud.Infrastructure.EntitiesConfig
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");
            builder.HasKey(o => o.EmployeeId);  
        } 
    }
}
