using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Contact
{
    public class ContactAddress
    {
        [Key]
        public int AddressId { get; set; }

        public string OfficeType { get; set; }

        public string Address { get; set; }

        public string ContactNumbers { get; set; }

        public string EmailIds { get; set; }

        public byte Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
