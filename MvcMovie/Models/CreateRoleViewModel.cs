using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class CreateRoleViewModel
    {
        [Required]
        public int Id { get; set; }
        public string? RoleName { get; set; }
    }
}
