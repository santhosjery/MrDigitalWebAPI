using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.EntityConfigurations;
using DomainModel.AppUser;
using DomainModel.Contact;
using DomainModel.Explore;
using DomainModel.ShowCase;
using DomainModel.WishList;

namespace DataAccessLayer
{
    public class DigitalAppContext : DbContext
    {
        public DigitalAppContext()
            : base("name=DefaultConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Users> Users { get; set; }

        public virtual DbSet<UsersOTP> UsersOTP { get; set; }

        public virtual DbSet<MachineTypes> MachineTypes { get; set; }

        public virtual DbSet<MachineVideos> MachineVideos { get; set; }

        public virtual DbSet<SliderImages> SliderImages { get; set; }

        public virtual DbSet<ShopMatches> ShopMatches { get; set; }

        public virtual DbSet<Explore> Explore { get; set; }

        public virtual DbSet<ExploreDetails> ExploreDetails { get; set; }

        public virtual DbSet<ContactDetails> ContactDetails { get; set; }

        public virtual DbSet<ContactAddress> ContactAddress { get; set; }

        public virtual DbSet<WishLists> WishLists { get; set; }

        public virtual DbSet<Faqs> Faqs { get; set; }

        public virtual DbSet<MachineSliderImages> MachineSliderImages { get; set; }

        public virtual DbSet<MachineDescription> MachineDescription { get; set; }

        public virtual DbSet<MachineRating> MachineRating { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Users>().ToTable("Users");
            //modelBuilder.Entity<UsersOTP>().ToTable("UsersOTP");
            //modelBuilder.Configurations.Add(new AllTablesConfiguration());
        }
    }
}