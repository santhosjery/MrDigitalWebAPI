using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel.Contact;
using IDataAccessLayer.IRepositories;

namespace DataAccessLayer.Repositories
{
    public class ShopMatchesRepository : Repository<ShopMatches>, IShopMatchesRepository
    {
        public ShopMatchesRepository(DigitalAppContext context)
            : base(context)
        {

        }
    }
}
