using System;
using System.Collections.Generic;
using System.Text;

namespace Dollop.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<MediaItem> Media { get; set; }
        public List<Album> Albums { get; set; }
    }
}
