using System.ComponentModel.DataAnnotations;

namespace HelloWorld.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(50)]
        public string username { get; set; }
        [Required]
        [MaxLength(50)]
        public string email { get; set; }
        [Required]
        [MaxLength(250)]
        public string password { get; set; }
    }
}
