using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using InmNow.Repository.Models.Mapping;

namespace InmNow.Repository.Models
{
    public partial class InmergeNowContext : DbContext
    {
        static InmergeNowContext()
        {
            Database.SetInitializer<InmergeNowContext>(null);
        }

        public InmergeNowContext()
            : base("Name=InmergeNowContext")
        {
        }

        public DbSet<AbstractOption> AbstractOptions { get; set; }
        public DbSet<Abstract> Abstracts { get; set; }
        public DbSet<AbstractUser> AbstractUsers { get; set; }
        public DbSet<Affiliation> Affiliations { get; set; }
        public DbSet<AspNetRole> AspNetRoles { get; set; }
        public DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public DbSet<AspNetUser> AspNetUsers { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Track> Tracks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AbstractOptionMap());
            modelBuilder.Configurations.Add(new AbstractMap());
            modelBuilder.Configurations.Add(new AbstractUserMap());
            modelBuilder.Configurations.Add(new AffiliationMap());
            modelBuilder.Configurations.Add(new AspNetRoleMap());
            modelBuilder.Configurations.Add(new AspNetUserClaimMap());
            modelBuilder.Configurations.Add(new AspNetUserLoginMap());
            modelBuilder.Configurations.Add(new AspNetUserMap());
            modelBuilder.Configurations.Add(new MeetingMap());
            modelBuilder.Configurations.Add(new OptionMap());
            modelBuilder.Configurations.Add(new SessionMap());
            modelBuilder.Configurations.Add(new TrackMap());
        }
    }
}
