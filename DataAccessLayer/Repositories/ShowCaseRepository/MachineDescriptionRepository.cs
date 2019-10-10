using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.ShowCase;
using IDataAccessLayer.IRepositories;

namespace DataAccessLayer.Repositories.ShowCaseRepository
{
    public class MachineDescriptionRepository : Repository<MachineDescription>, IMachineDescriptionRepository
    {
        public MachineDescriptionRepository(DigitalAppContext context)
            : base(context)
        {

        }

        public MachineRating GetMachineRating(int MachineId)
        {
            try
            {
                var Query = DigitalAppContext.MachineDescription
                                        .Join(DigitalAppContext.MachineRating,
                                                md => md.MachineId,
                                                mr => mr.MachineId,
                                                (mr, md) => new
                                                {
                                                    MachineId = md.MachineId,
                                                    Rating = md.Rating,
                                                    MachineRatingId = md.MachineRatingId
                                                });//.GroupBy(p => p.Rating);
                return Query.ToList().Select(r => new MachineRating
                {
                    MachineId = MachineId
                }).SingleOrDefault();
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
