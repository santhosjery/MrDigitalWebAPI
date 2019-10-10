using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.ShowCase
{
    public class ShowCase
    {
       public IEnumerable<SliderImages> SliderImages { get; set; }

       public IEnumerable<MachineTypes> MachineTypes { get; set; }

       public IEnumerable<MachineVideos> MachineVideos { get; set; }
    }
}
