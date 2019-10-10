using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Explore
{
    public class Explore
    {
        [Key]
        public int ExploreId { get; set; }

        public string ExploreName { get; set; }

        public string ExploreDescription { get; set; }

        public byte Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
