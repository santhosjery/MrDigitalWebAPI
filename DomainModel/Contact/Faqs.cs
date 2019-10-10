using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Contact
{
    public class Faqs
    {
        [Key]
        public int FaqId { get; set; }

        public string FaqQuestion { get; set; }

        public string FaqAnswer { get; set; }

        public byte Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
