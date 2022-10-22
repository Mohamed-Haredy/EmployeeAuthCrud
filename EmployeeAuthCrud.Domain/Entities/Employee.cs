using EmployeeAuthCrud.Domain.Base;
using System.ComponentModel.DataAnnotations;

namespace EmployeeAuthCrud.Domain.Entities
{
    public class Employee : Entity, IAggregateRoot
    {
        public int EmployeeId { get; set; }
        [Key]
        [Required]
        [StringLength(50, ErrorMessage = "This is too long name!!!")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "This is too long name!!!")]
        public string LastName { get; set; }
        
         
        public DateTime? BirthDate { get; set; }
        [Required]
        public string? Email { get; set; }

        public string? PhoneNumber { get; set; }

        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        public string? Comment { get; set; }

        public DateTime? JoinedDate { get; set; }

        public DateTime? ExitDate { get; set; }

        protected override IEnumerable<object> GetIdentityComponents()
        {
            yield return EmployeeId;
        }
    }
}