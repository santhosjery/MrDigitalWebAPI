using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Explore;
using IDataAccessLayer.IRepositories;

namespace DataAccessLayer.Repositories.ExploreRepository
{
    public class ExploreRepository : Repository<Explore>, IExploreRepository
    {
        public ExploreRepository(DigitalAppContext context)
            : base(context)
        {

        }

        public DigitalAppContext DigitalAppContext
        {
            get { return Context as DigitalAppContext; }
        }
    }
}
