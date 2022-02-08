using System.ComponentModel.DataAnnotations;
using SupportLibrary.Models;

namespace DataAccess.Models
{
    public class DisplayPersonModel : IPersonModel
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
