using System.Data.Entity;
using InmNow.Repository.Models;
using InmNow.Repository.Models.Mapping;
using InmNow.Repository.Models.Survey;
using Microsoft.AspNet.Identity.EntityFramework;

namespace InmNow.Repository.DbContexts
{
    public partial class InmergeNowContext : IdentityDbContext<IdentityUser>
    {

        static InmergeNowContext()
        {
            Database.SetInitializer<InmergeNowContext>(null);
        }
        public InmergeNowContext()
            : base("Name=InmergeNowContext")
        { }

        public DbSet<Affiliation> Affiliations { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<InmAbstract> InmAbstracts { get; set; }
        public DbSet<InmAbstractAuthor> InmAbstractAuthors { get; set; }
        public DbSet<InmAbstractOption> InmAbstractOptions { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<InmUser> InmUsers { get; set; }
        public DbSet<AuthorizedClient> AuthorizedClients { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AffiliationMap());
            modelBuilder.Configurations.Add(new AuthorMap());
            modelBuilder.Configurations.Add(new ClientMap());
            modelBuilder.Configurations.Add(new InmAbstractMap());
            modelBuilder.Configurations.Add(new InmAbstractAuthorMap());
            modelBuilder.Configurations.Add(new InmAbstractOptionMap());
            modelBuilder.Configurations.Add(new MeetingMap());
            modelBuilder.Configurations.Add(new OptionMap());
            modelBuilder.Configurations.Add(new SessionMap());
            modelBuilder.Configurations.Add(new TrackMap());
            modelBuilder.Configurations.Add(new InmUserMap());

            modelBuilder.Entity<IdentityUserLogin>().HasKey<string>(l => l.UserId);
            modelBuilder.Entity<IdentityRole>().HasKey<string>(r => r.Id);
            modelBuilder.Entity<IdentityUserRole>().HasKey(r => new { r.RoleId, r.UserId });
        }
    }
}
