using EmployeeAuthCrud.Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace EmployeeAuthCrud.Domain.Entities
{
    public class Country : Entity, IAggregateRoot
    {
        
        
        public int CountryId { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "This is too long name!!!")]
        public string Name { get; set; }

        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return CountryId;
        }
    }
}
