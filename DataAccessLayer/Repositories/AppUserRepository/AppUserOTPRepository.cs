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
    public class AppUserOTPRepository : Repository<UsersOTP>, IAppUserOTPRepository
    {
        public AppUserOTPRepository(DigitalAppContext context)
            : base(context)
        {

        }
        public UsersOTP SendOTP(Users users)
        {
            UsersOTP usersOTP = new UsersOTP();
            string AuthKey = ConfigurationManager.AppSettings["Msg91AuthKey"];
            string MobileNumber = users.MobileNumber.ToString();
            string SenderId = ConfigurationManager.AppSettings["Msg91SenderId"];
            string Message = ConfigurationManager.AppSettings["Msg91Message"] + new Random().Next(1000, 9999).ToString();

            StringBuilder SbPostData = new StringBuilder();
            SbPostData.AppendFormat("authkey={0}", AuthKey);
            SbPostData.AppendFormat("&mobiles={0}", MobileNumber);
            SbPostData.AppendFormat("&message={0}", Message);
            SbPostData.AppendFormat("&sender={0}", SenderId);
            SbPostData.AppendFormat("&route={0}", ConfigurationManager.AppSettings["Msg91Route"]);
            SbPostData.AppendFormat("&country={0}", ConfigurationManager.AppSettings["Msg91CountryCode"]);
            try
            {
                //Call Send SMS API
                string sendSMSUri = "http://api.msg91.com/api/sendhttp.php";
                //Create HTTPWebrequest
                HttpWebRequest httpWReq = (HttpWebRequest)WebRequest.Create(sendSMSUri);
                //Prepare and Add URL Encoded data
                UTF8Encoding encoding = new UTF8Encoding();
                byte[] data = encoding.GetBytes(SbPostData.ToString());
                //Specify post method
                httpWReq.Method = "POST";
                httpWReq.ContentType = "application/x-www-form-urlencoded";
                httpWReq.ContentLength = data.Length;
                using (Stream stream = httpWReq.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
                //Get the response
                HttpWebResponse response = (HttpWebResponse)httpWReq.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string responseString = reader.ReadToEnd();

                //Close the response
                reader.Close();
                response.Close();
                usersOTP.OTPNumber = 1234;
                usersOTP.UserId = users.UserId;
                usersOTP.CreatedDate = users.DateCreated;
                return usersOTP;
            }
            catch (SystemException ex)
            {
                return usersOTP;
            }

        }
    }
}
