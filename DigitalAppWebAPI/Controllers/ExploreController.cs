using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccessLayer;
using DomainModel.Explore;

namespace DigitalAppWebAPI.Controllers
{
    [RoutePrefix("api/Explore")]
    public class ExploreController : ApiController
    {
        UnitOfWork unitOfWork = new UnitOfWork(new DigitalAppContext());

        [HttpPost]
        [Route("GetAllExploreList")]
        public ExploreReturn GetAllExploreList()
        {
            try
            {
                var ExploreDetails = unitOfWork.ExploreDetails.GetAllExploreList();
                var ExploreHeader = unitOfWork.Explore.GetAll();
                ExploreReturn ExploreReturn = new ExploreReturn()
                {
                    ExploreHeader = ExploreHeader,
                    ExploreDetails = ExploreDetails
                };
                return ExploreReturn;
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
