using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Explore
{
    public class ExploreDetails
    {
        [Key]
        public int ExploreDetId { get; set; }

        public int ExploreId { get; set; }

        public string DetailName { get; set; }

        public string ImageName { get; set; }

        public string DetDescription { get; set; }

        public byte Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
