using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.ShowCase;
using IDataAccessLayer.IRepositories;

namespace DataAccessLayer.Repositories.ShowCaseRepository
{
    public class SliderImagesRepository : Repository<SliderImages>, ISliderImagesRepository
    {
        public SliderImagesRepository(DigitalAppContext context)
            : base(context)
        {

        }
    }
}
