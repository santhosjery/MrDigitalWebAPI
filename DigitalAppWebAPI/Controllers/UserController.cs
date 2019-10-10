using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccessLayer;
using DataAccessLayer.Repositories.AppUserRepository;
using DomainModel.AppUser;
using DomainModel.WishList;

namespace DigitalAppWebAPI.Controllers
{
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        [HttpPost]
        [Route("GetAllUsers")]
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
        [HttpPost]
        [Route("RegisterUser")]
        public int RegisterUser(Users users)
        {
            int LastInsertedId = 0;
            var unitOfWork = new UnitOfWork(new DigitalAppContext());
            try
            {
                unitOfWork.Users.Add(users);
                LastInsertedId = unitOfWork.Complete();

                if (LastInsertedId > 0)
                {
                    var usersOTP = unitOfWork.UserOTP.SendOTP(users);

                    unitOfWork.UserOTP.Add(usersOTP);
                    LastInsertedId = unitOfWork.Complete();

                    LastInsertedId = usersOTP.UserOTPId;
                }
                return LastInsertedId;
            }
            catch (Exception ex)
            {
                return LastInsertedId;
            }
            finally
            {
                unitOfWork.Dispose();
            }
        }
        [HttpPost]
        [Route("GetUserDetailsById")]
        public Users GetUserDetailsById(Users users)
        {
            var unitOfWork = new UnitOfWork(new DigitalAppContext());
            try
            {
                return unitOfWork.Users.GetById(users.UserId);
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
        [HttpPost]
        [Route("LoginUser")]
        public Users LoginUser(Users users)
        {
            var unitOfWork = new UnitOfWork(new DigitalAppContext());
            try
            {
                var UsersDetails = unitOfWork.Users.SingleOrDefault(u => u.MobileNumber == users.MobileNumber && u.Password == users.Password && u.IsActive == 1);
                if (UsersDetails != null)
                {
                    UsersDetails.LastLoginDate = users.LastLoginDate;
                    if(!string.IsNullOrEmpty(users.NotificationToken))
                    {
                        UsersDetails.NotificationToken = users.NotificationToken;
                    }
                    unitOfWork.Users.Update(UsersDetails);
                    unitOfWork.Complete();
                }
                return UsersDetails;
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
        [HttpPost]
        [Route("ValidateUserOTP")]
        public Users ValidateUserOTP(UsersOTP usersOTP)
        {
            var unitOfWork = new UnitOfWork(new DigitalAppContext());
            int LastUpdatedId = 0;
            var UserDetails = new Users();
            try
            {
                var OTPVerifiedCount = unitOfWork.UserOTP.SingleOrDefault(u => u.UserOTPId == usersOTP.UserOTPId && u.OTPNumber == usersOTP.OTPNumber);
                if (OTPVerifiedCount != null)
                {
                    UserDetails = unitOfWork.Users.SingleOrDefault(u => u.UserId == OTPVerifiedCount.UserId);
                    UserDetails.IsActive = 1;
                    unitOfWork.Users.Update(UserDetails);
                    LastUpdatedId = unitOfWork.Complete();
                }
                return UserDetails;
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
        [HttpPost]
        [Route("GetUsersWishLists")]
        public IEnumerable<WishLists> GetUsersWishLists(Users users)
        {
            var unitOfWork = new UnitOfWork(new DigitalAppContext());
            try
            {
                return unitOfWork.WishLists.Find(w => w.UserId == users.UserId).ToList();
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
