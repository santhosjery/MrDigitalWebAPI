using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.AppUser
{
    [Table("UsersOTP")]
    public class UsersOTP
    {
        [Key]
        public int UserOTPId { get; set; }

        public int UserId { get; set; }

        public int OTPNumber { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}
