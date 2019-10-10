using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Contact
{
    public class ContactDetails
    {
        [Key]
        public int ContactId { get; set; }

        public string ContactName { get; set; }

        public string ContactNumber { get; set; }

        public string Designation { get; set; }

        public string Remarks { get; set; }

        public byte Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
