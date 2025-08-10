using System.ComponentModel.DataAnnotations;

namespace Taskify.Web.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        public string? Phone { get; set; }

        [Required]
        public string? Gender { get; set; }

        [Required]
        public string? PresentAddress { get; set; }
        public string? PermanentAdress { get; set; }

        [Required]
        public string? ProfileImageUrl { get; set; }

        [Required]
        public string? University { get; set; }

    }
}
