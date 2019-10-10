using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.AppUserRepository;
using DataAccessLayer.Repositories.ExploreRepository;
using DataAccessLayer.Repositories.ShowCaseRepository;
using DomainModel.AppUser;
using DomainModel.Contact;
using DomainModel.ShowCase;
using DomainModel.WishList;
using IDataAccessLayer;
using IDataAccessLayer.IRepositories;
using IDataAccessLayer.IRepositories.IAppUserRepository;

namespace DataAccessLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DigitalAppContext _context;

        public UnitOfWork(DigitalAppContext context)
        {
            _context = context;
            Users = new AppUserRepository(_context);
            UserOTP = new AppUserOTPRepository(_context);
            MachineTypes = new MachineTypesRepository(_context);
            MachineVideos = new Repository<MachineVideos>(_context);
            SliderImages = new SliderImagesRepository(_context);
            ShopMatches = new ShopMatchesRepository(_context);
            Explore = new ExploreRepository(_context);
            ExploreDetails = new ExploreDetailsRepository(_context);
            ContactDetails = new Repository<ContactDetails>(_context);
            ContactAddress = new Repository<ContactAddress>(_context);
            WishLists = new Repository<WishLists>(_context);
            Faqs = new Repository<Faqs>(_context);
            MachineSliderImages = new Repository<MachineSliderImages>(_context);
            MachineDescription = new MachineDescriptionRepository(_context);
            Specifications = new Repository<MachineDescription>(_context);
        }

        public IAppUserRepository Users { get; private set; }

        public IAppUserOTPRepository UserOTP { get; private set; }

        public IMachineTypesRepository MachineTypes { get; private set; }

        public IRepository<MachineVideos> MachineVideos { get; private set; }

        public ISliderImagesRepository SliderImages { get; private set; }

        public IShopMatchesRepository ShopMatches { get; private set; }

        public IExploreRepository Explore { get; private set; }

        public IExploreDetailsRepository ExploreDetails { get; private set; }

        public IRepository<ContactDetails> ContactDetails { get; private set; }

        public IRepository<ContactAddress> ContactAddress { get; private set; }

        public IRepository<WishLists> WishLists { get; private set; }

        public IRepository<Faqs> Faqs { get; private set; }

        public IRepository<MachineSliderImages> MachineSliderImages { get; private set; }

        public IMachineDescriptionRepository MachineDescription { get; private set; }

        public IRepository<MachineDescription> Specifications { get; private set; }

        public int Complete()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
