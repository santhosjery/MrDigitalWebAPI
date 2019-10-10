using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.AppUser
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailId { get; set; }

        public string MobileNumber { get; set; }

        public string Password { get; set; }

        public byte UserRole { get; set; }

        public byte IsActive { get; set; }

        public string NotificationToken { get; set; }

        public DateTime? LastLoginDate { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
