using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace COREE.Models
{
    [Table("Users")]
    class User
    {
        [Key]
        public long UserID { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public long PostID { get; set; }
        public string PhoneNumber { get; set; }
    }
}
