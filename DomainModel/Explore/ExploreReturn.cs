using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.Explore
{
    public class ExploreReturn
    {
        public IEnumerable<Explore> ExploreHeader { get; set; }

        public IEnumerable<ExploreDetails> ExploreDetails { get; set; }
    }
}
