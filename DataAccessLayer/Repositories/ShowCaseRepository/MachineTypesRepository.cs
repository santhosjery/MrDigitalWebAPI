using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.ShowCase;
using IDataAccessLayer.IRepositories;

namespace DataAccessLayer.Repositories.ShowCaseRepository
{
    public class MachineTypesRepository : Repository<MachineTypes>, IMachineTypesRepository
    {
        public MachineTypesRepository(DigitalAppContext context)
            : base(context)
        {

        }
    }
}
