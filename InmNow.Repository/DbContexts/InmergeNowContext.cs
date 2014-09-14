using System.Data.Entity;
using InmNow.Repository.Models;
using InmNow.Repository.Models.Mapping;

namespace InmNow.Repository.DbContexts
{
    public partial class InmergeNowContext : BaseContext<InmergeNowContext>
    {

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
        }
    }
}
