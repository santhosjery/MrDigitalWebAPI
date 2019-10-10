using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.ShowCase
{
    public class MachineMaster
    {
        public IEnumerable<MachineSliderImages> MachineSliderImages { get; set; }

        public MachineRating MachineRating { get; set; }

        public MachineDescription MachineSpecifications { get; set; }

        public IEnumerable<MachineVideos> RelatedVideos { get; set; }
    }
}
