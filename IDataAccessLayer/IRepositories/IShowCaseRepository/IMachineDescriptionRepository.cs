using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.ShowCase;

namespace IDataAccessLayer.IRepositories
{
    public interface IMachineDescriptionRepository : IRepository<MachineDescription>
    {
        MachineRating GetMachineRating(int MachineId);
    }
}