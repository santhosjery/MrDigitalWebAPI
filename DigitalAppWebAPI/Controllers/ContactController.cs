using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccessLayer;
using DomainModel.Contact;

namespace DigitalAppWebAPI.Controllers
{
    [RoutePrefix("api/Contact")]
    public class ContactController : ApiController
    {
        UnitOfWork unitOfWork = new UnitOfWork(new DigitalAppContext());

        [HttpPost]
        [Route("GetAllShopMatches")]
        public IEnumerable<ShopMatches> GetAllShopMatches()
        {
            try
            {
                return unitOfWork.ShopMatches.GetAll();
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
        [Route("GetAllContactDetails")]
        public ContactMaster GetAllContactDetails()
        {
            try
            {
                ContactMaster ContactMaster = new ContactMaster()
                {
                    ContactAddresses = unitOfWork.ContactAddress.GetAll(),
                    ContactDetails = unitOfWork.ContactDetails.GetAll()
                };
                return ContactMaster;
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
        [Route("GetAllFaqs")]
        public IEnumerable<Faqs> GetAllFaqs()
        {
            try
            {
                return unitOfWork.Faqs.GetAll();
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