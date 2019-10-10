using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.ShowCase
{
    public class MachineRating
    {
        [Key]
        public int MachineRatingId { get; set; }

        public int MachineId { get; set; }

        public int UserId { get; set; }

        public int Rating { get; set; }

        public byte Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
