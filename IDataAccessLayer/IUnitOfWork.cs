using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDataAccessLayer.IRepositories;
using IDataAccessLayer.IRepositories.IAppUserRepository;

namespace IDataAccessLayer
{
    public interface IUnitOfWork
    {
        IAppUserRepository Users { get; }

        IAppUserOTPRepository UserOTP { get; }

        IMachineTypesRepository MachineTypes { get; }

        ISliderImagesRepository SliderImages { get; }

        IShopMatchesRepository ShopMatches { get; }

        IExploreRepository Explore { get; }

        IExploreDetailsRepository ExploreDetails { get; }

        int Complete();
    }
}
