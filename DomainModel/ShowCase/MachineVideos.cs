using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.ShowCase
{
    public class MachineVideos
    {
        [Key]
        public int MachineVideoId { get; set; }

        public int MachineId { get; set; }

        public string VideoName { get; set; }

        public string VideoDescription { get; set; }

        public byte Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
