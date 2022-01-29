using System.ComponentModel.DataAnnotations;

namespace TulisanKita.Models
{
    public class Roles
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
