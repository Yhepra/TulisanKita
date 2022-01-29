using System.ComponentModel.DataAnnotations;

namespace TulisanKita.Models
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }   
        public Roles Roles { get; set; }
    }
}
