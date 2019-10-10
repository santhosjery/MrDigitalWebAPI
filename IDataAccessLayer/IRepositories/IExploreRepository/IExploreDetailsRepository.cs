using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Explore;

namespace IDataAccessLayer.IRepositories
{
    public interface IExploreDetailsRepository : IRepository<ExploreDetails>
    {
        IEnumerable<ExploreDetails> GetAllExploreList();
    }
}
