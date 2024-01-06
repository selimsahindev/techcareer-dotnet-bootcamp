using System.ComponentModel.DataAnnotations;

namespace TechcareerDotnetBootcamp.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; private set; }

        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; private set; } = default!;

        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; private set; } = default!;

        public string? Address { get; private set; }
        public DateTime? BirthDate { get; private set; }
        public string? City { get; private set; }
        public DateTime? AddDate { get; private set; }
    }
}
