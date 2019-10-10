using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Contact
{
    public class ShopMatches
    {
        [Key]
        public int ShopMatchId { get; set; }

        public string ContactDescription { get; set; }

        public string ContactNumber { get; set; }

        public byte Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

    }
}
