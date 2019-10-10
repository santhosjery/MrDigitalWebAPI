using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DomainModel.AppUser;
using IDataAccessLayer.IRepositories.IAppUserRepository;

namespace DataAccessLayer.Repositories.AppUserRepository
{
    public class AppUserRepository : Repository<Users>, IAppUserRepository
    {
        public AppUserRepository(DigitalAppContext context)
            : base(context)
        {

        }
    }
}