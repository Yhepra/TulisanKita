using System;

namespace TulisanKita.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Status { get; set; }
        public User User { get; set; }
    }
}
