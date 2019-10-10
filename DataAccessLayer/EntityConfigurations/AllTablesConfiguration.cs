using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace DataAccessLayer.EntityConfigurations
{
    public class AllTablesConfiguration : EntityTypeConfiguration<AllTableReferences>
    {
        public AllTablesConfiguration()
        {
            HasRequired(us => us.Users);
        }
    }
}
