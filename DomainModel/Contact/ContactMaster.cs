using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Contact
{
    public class ContactMaster
    {
        public IEnumerable<ContactDetails> ContactDetails { get; set; }

        public IEnumerable<ContactAddress> ContactAddresses { get; set; }
    }
}
