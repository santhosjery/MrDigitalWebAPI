using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccessLayer;
using DomainModel.ShowCase;

namespace DigitalAppWebAPI.Controllers
{
    [RoutePrefix("api/ShowCase")]
    public class ShowCaseController : ApiController
    {
        UnitOfWork unitOfWork = new UnitOfWork(new DigitalAppContext());

        [HttpPost]
        [Route("GetAllShowCase")]
        public ShowCase GetAllShowCase()
        {
            try
            {
                ShowCase showCase = new ShowCase()
                {
                    SliderImages = unitOfWork.SliderImages.GetAll(),
                    MachineTypes = unitOfWork.MachineTypes.GetAll(),
                    MachineVideos = unitOfWork.MachineVideos.GetAll()
                };
                return showCase;
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
        [Route("GetMachineDescriptionById")]
        public MachineMaster GetMachineDescriptionById(MachineTypes machineTypes)
        {
            try
            {
                MachineMaster machineMaster = new MachineMaster()
                {
                    MachineSliderImages = unitOfWork.MachineSliderImages.Find(ms => ms.MachineId == machineTypes.MachineId).ToList(),
                    MachineRating = unitOfWork.MachineDescription.GetMachineRating(machineTypes.MachineId),
                    MachineSpecifications = unitOfWork.MachineDescription.Find(md => md.MachineId == machineTypes.MachineId).SingleOrDefault(),
                    RelatedVideos = unitOfWork.MachineVideos.Find(mv => mv.MachineId == machineTypes.MachineId).ToList()
                };
                return machineMaster;
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
