using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DomainModel.AppUser;

namespace DataServiceLayer.AppUser
{
    public class UserService
    {
        public IEnumerable<Users> GetAllUsers()
        {
            var unitOfWork = new UnitOfWork(new DigitalAppContext());
            try
            {
                return unitOfWork.Users.GetAll();
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                unitOfWork.Dispose();
            }
        }
    }
}
