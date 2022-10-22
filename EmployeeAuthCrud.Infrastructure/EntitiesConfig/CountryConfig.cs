using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EmployeeAuthCrud.Domain.Entities;

namespace EmployeeAuthCrud.Infrastructure.EntitiesConfig
{
    public class CountryConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Countries");
            builder.HasKey(o => o.CountryId);  
        } 
    }
}
