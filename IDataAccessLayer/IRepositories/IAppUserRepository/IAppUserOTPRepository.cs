using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.AppUser;

namespace IDataAccessLayer.IRepositories.IAppUserRepository
{
    public interface IAppUserOTPRepository : IRepository<UsersOTP>
    {
        UsersOTP SendOTP(Users users);
    }
}
