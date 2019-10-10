using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Explore;
using IDataAccessLayer.IRepositories;

namespace DataAccessLayer.Repositories.ExploreRepository
{
    public class ExploreDetailsRepository : Repository<ExploreDetails>, IExploreDetailsRepository
    {
        public ExploreDetailsRepository(DigitalAppContext context)
            : base(context)
        {

        }

        public IEnumerable<ExploreDetails> GetAllExploreList()
        {
            try
            {
                var Query = DigitalAppContext.Explore
                                        .Join(DigitalAppContext.ExploreDetails,
                                                d => d.ExploreId,
                                                e => e.ExploreId,
                                                (e, d) => new
                                                {
                                                    ExploreId = d.ExploreId,
                                                    ExploreDetId = d.ExploreDetId,
                                                    DetailName = d.DetailName,
                                                    ImageName = d.ImageName,
                                                    DetDescription = d.DetDescription,
                                                    Status = d.Status,
                                                    CreatedDate = d.CreatedDate
                                                });
                return Query.ToList().Select(r => new ExploreDetails
                {
                    ExploreId = r.ExploreId,
                    ExploreDetId = r.ExploreDetId,
                    DetailName = r.DetailName,
                    ImageName = r.ImageName,
                    DetDescription = r.DetDescription,
                    Status = r.Status,
                    CreatedDate = r.CreatedDate
                }).ToList();
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public DigitalAppContext DigitalAppContext
        {
            get { return Context as DigitalAppContext; }
        }
    }
}
