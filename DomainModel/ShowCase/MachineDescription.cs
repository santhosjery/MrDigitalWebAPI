using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.ShowCase
{
    public class MachineDescription
    {
        [Key]
        public int MachineDescriptionId { get; set; }

        public int MachineId { get; set; }

        public string Description { get; set; }

        public string PlateType { get; set; }

        public string Dimensional { get; set; }

        public string Weight { get; set; }

        public string Capacity { get; set; }

        public string MediaType { get; set; }

        public string InkType { get; set; }

        public string Interface { get; set; }

        public byte Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
