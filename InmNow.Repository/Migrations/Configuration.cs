using System;
using InmNow.Enums;
using InmNow.Repository.DbContexts;
using InmNow.Repository.Models;
using InmNow.Repository.Models.Survey;
using InmNow.Utils.Cryptography;

namespace InmNow.Repository.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<InmergeNowContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(InmergeNowContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //

            //context.AuthorizedClients.AddOrUpdate(
                
            //    a=>a.Id,
            //    new AuthorizedClient { Id = "inmShowApp", Name = "Inmerge Angular UI", Secret = HashHelper.GetHash("Q@#eszaw"), Active = true, 
            //        AllowedOrigin = "http://localhost:55792", RefreshTokenLifeTime = 7200, ApplicationType = ApplicationTypes.JavaScript}
                    
            //        );

            //context.Clients.AddOrUpdate(
            //    c => c.Email,
            //    new Client { Name = "Test Client 1", Description = "Test client 1 descripton", Contact="William Thomas", Email = "testclient1@inm.com", Phone = "(123) 456-789", Website = "testclient1.inm.com", Active = true},
            //    new Client { Name = "Test Client 2", Description = "Test client 2 descripton", Contact = "Tom Thomas", Email = "testclient2@inm.com", Phone = "(321) 456-789", Website = "testclient2.inm.com", Active = true },
            //    new Client { Name = "Test Client 3", Description = "Test client 3 descripton", Contact = "Carol Thomas", Email = "testclient3@inm.com", Phone = "(231) 456-789", Website = "testclient3.inm.com", Active = false }
            //    );

            //context.Affiliations.AddOrUpdate(
            //    a => a.Name,
            //    new Affiliation { Name = "Affiliation 1", Type = 1, Street = "Affiliation 1 address", Unit = "Unit 1", Region = "Region1", Postal = "87505", Country = "USA",  Website = "affiliation1.com" },
            //    new Affiliation { Name = "Affiliation 2", Type = 2, Street = "Affiliation 2 address", Unit = "Unit 2", Region = "Region2", Postal = "80227", Country = "USA", Website = "affiliation2.com" },
            //    new Affiliation { Name = "Affiliation 3", Type = 3, Street = "Affiliation 3 address", Unit = "Unit 3", Region = "Region3", Postal = "87144", Country = "USA", Website = "affiliation3.com" }
            //    );

            //context.Meetings.AddOrUpdate(
            //    m => m.Title,
            //    new Meeting
            //    {
            //        Title = "Inmerge Annual Conference",
            //        Description = "A test conference",
            //        StartDate = DateTime.Parse("2013-09-01"),
            //        EndDate = DateTime.Parse("2013-09-08"),
            //        Contact = "William Thomas",
            //        Location = "Broomfield",
            //        OfficeEmail = "will.thomas@inmerge.com",
            //        SupportEmail = "support@inmerge.com"

            //    },
            //    new Meeting
            //    {
            //        Title = "Willco Annual Conference",
            //        Description = "A test conference",
            //        StartDate = DateTime.Parse("2013-09-01"),
            //        EndDate = DateTime.Parse("2013-09-08"),
            //        Contact = "William Thomas",
            //        Location = "Lakewood",
            //        OfficeEmail = "wthomas@inmerge.com",
            //        SupportEmail = "support@inmerge.com"

            //    }
            //    );

            //context.Tracks.AddOrUpdate(
            //    t => t.Title,
            //    new Track
            //    {
            //        Title = "Oral Presentations",
            //        Type = 1,
            //        StartDate = DateTime.Parse("2013-09-01"),
            //        EndDate = DateTime.Parse("2013-09-01")
            //    },
            //    new Track
            //    {
            //        Title = "Poster Presentations",
            //        Type = 2,
            //        StartDate = DateTime.Parse("2013-09-01"),
            //        EndDate = DateTime.Parse("2013-09-01")

            //    },
            //    new Track
            //    { 
            //        Title = "Keynote and Invited",
            //        Type = 3,
            //        StartDate = DateTime.Parse("2013-09-01"),
            //        EndDate = DateTime.Parse("2013-09-01")
            //    });

            //context.Sessions.AddOrUpdate(
            //    s => s.SessionTitle,
            //    new Session
            //    {
            //        SessionTitle = "Asp.net MVC Basics",
            //        Code = "O01",
            //        Contact = "Tom Thomas",
            //        ContactEmail = "tom.thomas@inmerge.com",
            //        StartDate = DateTime.Parse("2013-09-01"),
            //        EndDate = DateTime.Parse("2013-09-01"),
            //        Location = "Santa Fe",
            //        Phase = 1
            //    },
            //    new Session
            //    {
            //        SessionTitle = "Entity Framework 6.0 Code First",
            //        Code = "O02",
            //        Contact = "Tom Thomas",
            //        ContactEmail = "tom.thomas@inmerge.com",
            //        StartDate = DateTime.Parse("2013-09-01"),
            //        EndDate = DateTime.Parse("2013-09-01"),
            //        Location = "Santa Fe",
            //        Phase = 1
            //    },
            //    new Session
            //    {
            //        SessionTitle = "Bootstrap 3.0 Changes",
            //        Code = "P01",
            //        Contact = "Will Thomas",
            //        ContactEmail = "will.thomas@inmerge.com",
            //        StartDate = DateTime.Parse("2013-09-01"),
            //        EndDate = DateTime.Parse("2013-09-01"),
            //        Location = "Broomfield",
            //        Phase = 2
            //    },
            //    new Session
            //    {
            //        SessionTitle = "Advanced CSS",
            //        Code = "P02",
            //        Contact = "Will Thomas",
            //        ContactEmail = "will.thomas@inmerge.com",
            //        StartDate = DateTime.Parse("2013-09-01"),
            //        EndDate = DateTime.Parse("2013-09-01"),
            //        Location = "Broomfield",
            //        Phase = 1
            //    },
            //    new Session
            //    {
            //        SessionTitle = "JQuery Fundamentals",
            //        Code = "K01",
            //        Contact = "Carol Thomas",
            //        ContactEmail = "carol.thomas@inmerge.com",
            //        StartDate = DateTime.Parse("2013-09-01"),
            //        EndDate = DateTime.Parse("2013-09-01"),
            //        Location = "Malibu",
            //        Phase = 1
            //    },
            //    new Session
            //    {
            //        SessionTitle = "Advanced Javascript Databinding",
            //        Code = "K02",
            //        Contact = "Barbara Thomas",
            //        ContactEmail = "barbara.thomas@inmerge.com",
            //        StartDate = DateTime.Parse("2013-09-01"),
            //        EndDate = DateTime.Parse("2013-09-01"),
            //        Location = "Malibu",
            //        Phase = 2
            //    });

            //context.InmAbstracts.AddOrUpdate(
            //    a => a.Title,
            //    new InmAbstract
            //    {
            //        Title = "My First MVC app",
            //        Introduction = "I've studied for a long time...",
            //        Methods = "I worked really hard...",
            //        Results = "And this is what I learned...",
            //        Lognumber = 1,
            //        PreferredTrackType = 1,
            //        Status = 1,
            //        AssignedSlot = "1001",
            //        NovelAspect = "It's interesting...",
            //        IsLocked = false,
            //        SubmittedDate = DateTime.Parse("2013-04-04"),
            //        PresentationDate = DateTime.Parse("2013-09-01"),
            //        ModifiedDate = DateTime.Parse("2013-09-01"),
            //        PublishDate = DateTime.Parse("2013-09-01"),
            //        UploadedFile = "myfile.pdf",
            //        UploadedFileStatus = 1
            //    },
            //    new InmAbstract
            //    {
            //        Title = "My Second MVC app",
            //        Introduction = "I've studied for a long time...",
            //        Methods = "I worked really hard...",
            //        Results = "And this is what I learned...",
            //        Lognumber = 2,
            //        PreferredTrackType = 1,
            //        Status = 1,
            //        AssignedSlot = "1002",
            //        NovelAspect = "It's interesting...",
            //        IsLocked = false,
            //        SubmittedDate = DateTime.Parse("2013-04-04"),
            //        PresentationDate = DateTime.Parse("2013-09-01"),
            //        ModifiedDate = DateTime.Parse("2013-09-01"),
            //        PublishDate = DateTime.Parse("2013-09-01"),
            //        UploadedFile = "myfile.pdf",
            //        UploadedFileStatus = 1
            //    },
            //    new InmAbstract
            //    {
            //        Title = "My Third MVC app",
            //        Introduction = "I've studied for a long time...",
            //        Methods = "I worked really hard...",
            //        Results = "And this is what I learned...",
            //        Lognumber = 3,
            //        PreferredTrackType = 2,
            //        Status = 2,
            //        AssignedSlot = "1003",
            //        NovelAspect = "It's interesting...",
            //        IsLocked = false,
            //        SubmittedDate = DateTime.Parse("2013-03-02"),
            //        PresentationDate = DateTime.Parse("2013-09-01"),
            //        ModifiedDate = DateTime.Parse("2013-09-01"),
            //        PublishDate = DateTime.Parse("2013-09-01"),
            //        UploadedFile = "myfile.pdf",
            //        UploadedFileStatus = 2
            //    },
            //    new InmAbstract
            //    {
            //        Title = "My Forth MVC app",
            //        Introduction = "I've studied for a long time...",
            //        Methods = "I worked really hard...",
            //        Results = "And this is what I learned...",
            //        Lognumber = 4,
            //        PreferredTrackType = 1,
            //        Status = 1,
            //        AssignedSlot = "1004",
            //        NovelAspect = "It's interesting...",
            //        IsLocked = false,
            //        SubmittedDate = DateTime.Parse("2013-09-05"),
            //        PresentationDate = DateTime.Parse("2013-09-01"),
            //        ModifiedDate = DateTime.Parse("2013-09-01"),
            //        PublishDate = DateTime.Parse("2013-09-01"),
            //        UploadedFile = "myfile.pdf",
            //        UploadedFileStatus = 1
            //    });

            //context.Affiliations.People.AddOrUpdate(
            //  p => p.FullName,
            //  new Person { FullName = "Andrew Peters" },
            //  new Person { FullName = "Brice Lambson" },
            //  new Person { FullName = "Rowan Miller" }
            //);
            
            
//            var users = new List<InmUser>
//            {
//                //3 test users
//                new InmUser
//                {
//                    FirstName = "William",
//                    LastName = "Thomas",
//                    Email = "will.thomas@inmerge.com",
//                    Country = "United States",
//                    Region = "Colorado",
//                    Type = UserType.Presenter,
//                    UserName = "will",
//                    Abstracts = new List<Abstract>(),
//                    Affiliations = new List<Affiliation>()
//                },
//                new InmUser
//                {
//                    FirstName = "Tom",
//                    LastName = "Thomas",
//                    Email = "tom.thomas@inmerge.com",
//                    Country = "United States",
//                    Region = "New Mexico",
//                    Type = UserType.Presenter,
//                    UserName = "tom",
//                    Abstracts = new List<Abstract>(),
//                    Affiliations = new List<Affiliation>()
//                },
//                new InmUser
//                {
//                    FirstName = "Carol",
//                    LastName = "Thomas",
//                    Email = "carol.thomas@inmerge.com",
//                    Country = "United States",
//                    Region = "Colorado",
//                    Type = UserType.Staff,
//                    UserName = "carol",
//                    Abstracts = new List<Abstract>(),
//                    Affiliations = new List<Affiliation>()
//                }
//            };

//            foreach (InmUser userToAdd in users)
//            {
//                adminresult = UserManager.Create(userToAdd, password);
//                if (adminresult.Succeeded)
//                {
//                    IdentityResult result = UserManager.AddToRole(userToAdd.Id, presenterRole);
//                }
//            }


//            var affiliations = new List<Affiliation>
//            {
//                //4 test affiliations
//                new Affiliation
//                {
//                    Name = "Inmerge Inc",
//                    Address = "Santa Fe, NM",
//                    Country = "United States",
//                    Type = AffiliationType.Corporation,
//                    Website = "http://inmerge.com"
//                },
//                new Affiliation
//                {
//                    Name = "Woodsilks",
//                    Address = "Santa Fe, NM",
//                    Country = "United States",
//                    Type = AffiliationType.Special,
//                    Website = "http://woodsilks.com"
//                },
//                new Affiliation
//                {
//                    Name = "WillCo",
//                    Address = "Broomfield, CO",
//                    Country = "United States",
//                    Type = AffiliationType.Nonprofit,
//                    Website = "http://willco.com"
//                },
//                new Affiliation
//                {
//                    Name = "UNM",
//                    Address = "Albuquerque, NM",
//                    Country = "United States",
//                    Type = AffiliationType.Educational,
//                    Website = "http://UNM.org"
//                }
//            };

//            affiliations.ForEach(s => context.Affiliations.AddOrUpdate(p => p.AffiliationId, s));
//            context.SaveChanges();

//            //add affiliation to user
//            users[0].Affiliations.Add(affiliations[0]);
//            users[1].Affiliations.Add(affiliations[1]);
//            users[2].Affiliations.Add(affiliations[2]);
//            context.SaveChanges();

//            #endregion

//            #region MeetingsOptionsAndTracks

//            var meetings = new List<Meeting>
//            {
//                //1 test meeting, we'll expand to more later
//                new Meeting
//                {
//                    Title = "Inmerge Annual Conference",
//                    Description = "A test conference",
//                    StartDate = DateTime.Parse("2013-09-01"),
//                    EndDate = DateTime.Parse("2013-09-08"),
//                    Contact = "William Thomas",
//                    Location = "Broomfield",
//                    OfficeEmail = "will.thomas@inmerge.com",
//                    SupportEmail = "support@inmerge.com",
//                    Tracks = new List<Track>()
//                }
//            };

//            //Save meeting
//            meetings.ForEach(s => context.Meetings.AddOrUpdate(p => p.MeetingId, s));
//            context.SaveChanges();

//            var options = new List<Option>
//            {
//                //4 test options
//                new Option
//                {
//                    Question = "Would you like to give a talk?",
//                    Meeting = meetings.FirstOrDefault(d => d.MeetingId == 1),
//                    Type = OptionType.Boolean,
//                    QuestionDescription = "There are a limited number of talks available."
//                },
//                new Option
//                {
//                    Question = "Would you like to apply for a student stipend?",
//                    Meeting = meetings.FirstOrDefault(d => d.MeetingId == 1),
//                    Type = OptionType.Boolean,
//                    QuestionDescription = "You must be a full time student."
//                },
//                new Option
//                {
//                    Question = "Favorite color?",
//                    Meeting = meetings.FirstOrDefault(d => d.MeetingId == 1),
//                    Type = OptionType.Text,
//                    QuestionDescription = "Pinks will be banned from the meeting."
//                },
//                new Option
//                {
//                    Question = "Are you a student presenter?",
//                    Meeting = meetings.FirstOrDefault(d => d.MeetingId == 1),
//                    Type = OptionType.HasSub,
//                    QuestionDescription = "Prove it.",
//                    SubOptions = new List<Option>()
//                },
//                new Option
//                {
//                    Question = "My professor's name is",
//                    Meeting = meetings.FirstOrDefault(d => d.MeetingId == 1),
//                    Type = OptionType.IsSub,
//                    QuestionDescription = "Must be a real person."
//                }
//            };

//            options.ForEach(s => context.Options.AddOrUpdate(p => p.OptionId, s));
//            context.SaveChanges();

//            //add options to meeting
//            meetings[0].Options.Add(options[0]);
//            meetings[0].Options.Add(options[1]);
//            meetings[0].Options.Add(options[2]);
//            meetings[0].Options.Add(options[3]);
//            context.SaveChanges();

//            //add suboption to parentoption
//            options[3].SubOptions.Add(options[4]);
//            context.SaveChanges();

//            var tracks = new List<Track>
//            {
//                //3 test tracks
//                new Track
//                {
//                    Title = "Oral Presentations",
//                    Type = TrackType.Talk,
//                    Meeting = meetings.FirstOrDefault(d => d.MeetingId == 1),
//                    StartDate = DateTime.Parse("2013-09-01"),
//                    EndDate = DateTime.Parse("2013-09-01"),
//                    Sessions = new List<Session>()
//                },
//                new Track
//                {
//                    Title = "Poster Presentations",
//                    Type = TrackType.Poster,
//                    Meeting = meetings.FirstOrDefault(d => d.MeetingId == 1),
//                    StartDate = DateTime.Parse("2013-09-01"),
//                    EndDate = DateTime.Parse("2013-09-01"),
//                    Sessions = new List<Session>()
//                },
//                new Track
//                {
//                    Title = "Keynote and Invited",
//                    Type = TrackType.Keynote,
//                    Meeting = meetings.FirstOrDefault(d => d.MeetingId == 1),
//                    StartDate = DateTime.Parse("2013-09-01"),
//                    EndDate = DateTime.Parse("2013-09-01"),
//                    Sessions = new List<Session>()
//                }
//            };

//            tracks.ForEach(s => context.Tracks.AddOrUpdate(p => p.TrackId, s));
//            context.SaveChanges();

//            //add tracks to meeting
//            meetings[0].Tracks.Add(tracks[0]);
//            meetings[0].Tracks.Add(tracks[1]);
//            meetings[0].Tracks.Add(tracks[2]);
//            context.SaveChanges();

//            #endregion

//            var sessions = new List<Session>
//            {
//                //6 test sessions
//                new Session
//                {
//                    SessionTitle = "Asp.net MVC Basics",
//                    Abstracts = new List<Abstract>(),
//                    Code = "O01",
//                    Contact = "Tom Thomas",
//                    ContactEmail = "tom.thomas@inmerge.com",
//                    StartDate = DateTime.Parse("2013-09-01"),
//                    EndDate = DateTime.Parse("2013-09-01"),
//                    Location = "Santa Fe",
//                    Phase = SessionPhase.Entry,
//                    Track = tracks.FirstOrDefault(d => d.TrackId == 1)
//                },
//                new Session
//                {
//                    SessionTitle = "Entity Framework 6.0 Code First",
//                    Abstracts = new List<Abstract>(),
//                    Code = "O02",
//                    Contact = "Tom Thomas",
//                    ContactEmail = "tom.thomas@inmerge.com",
//                    StartDate = DateTime.Parse("2013-09-01"),
//                    EndDate = DateTime.Parse("2013-09-01"),
//                    Location = "Santa Fe",
//                    Phase = SessionPhase.Entry,
//                    Track = tracks.FirstOrDefault(d => d.TrackId == 1)
//                },
//                new Session
//                {
//                    SessionTitle = "Bootstrap 3.0 Changes",
//                    Abstracts = new List<Abstract>(),
//                    Code = "P01",
//                    Contact = "Will Thomas",
//                    ContactEmail = "will.thomas@inmerge.com",
//                    StartDate = DateTime.Parse("2013-09-01"),
//                    EndDate = DateTime.Parse("2013-09-01"),
//                    Location = "Broomfield",
//                    Phase = SessionPhase.Entry,
//                    Track = tracks.FirstOrDefault(d => d.TrackId == 2)
//                },
//                new Session
//                {
//                    SessionTitle = "Advanced CSS",
//                    Abstracts = new List<Abstract>(),
//                    Code = "P02",
//                    Contact = "Will Thomas",
//                    ContactEmail = "will.thomas@inmerge.com",
//                    StartDate = DateTime.Parse("2013-09-01"),
//                    EndDate = DateTime.Parse("2013-09-01"),
//                    Location = "Broomfield",
//                    Phase = SessionPhase.Entry,
//                    Track = tracks.FirstOrDefault(d => d.TrackId == 2)
//                },
//                new Session
//                {
//                    SessionTitle = "JQuery Fundamentals",
//                    Abstracts = new List<Abstract>(),
//                    Code = "K01",
//                    Contact = "Carol Thomas",
//                    ContactEmail = "carol.thomas@inmerge.com",
//                    StartDate = DateTime.Parse("2013-09-01"),
//                    EndDate = DateTime.Parse("2013-09-01"),
//                    Location = "Malibu",
//                    Phase = SessionPhase.Entry,
//                    Track = tracks.FirstOrDefault(d => d.TrackId == 3)
//                },
//                new Session
//                {
//                    SessionTitle = "Advanced Javascript Databinding",
//                    Abstracts = new List<Abstract>(),
//                    Code = "K02",
//                    Contact = "Barbara Thomas",
//                    ContactEmail = "barbara.thomas@inmerge.com",
//                    StartDate = DateTime.Parse("2013-09-01"),
//                    EndDate = DateTime.Parse("2013-09-01"),
//                    Location = "Malibu",
//                    Phase = SessionPhase.Entry,
//                    Track = tracks.FirstOrDefault(d => d.TrackId == 3)
//                }
//            };

//            sessions.ForEach(s => context.Sessions.AddOrUpdate(p => p.SessionId, s));
//            context.SaveChanges();

//            tracks[0].Sessions.Add(sessions[0]);
//            tracks[0].Sessions.Add(sessions[1]);
//            tracks[1].Sessions.Add(sessions[2]);
//            tracks[1].Sessions.Add(sessions[3]);
//            tracks[2].Sessions.Add(sessions[4]);
//            tracks[2].Sessions.Add(sessions[5]);
//            context.SaveChanges();

//            var abstracts = new List<Abstract>
//            {
//                //4 test abstracts

//                new Abstract
//                {
//                    Title = "My First MVC app",
//                    Introduction = "I've studied for a long time...",
//                    Methods = "I worked really hard...",
//                    Results = "And this is what I learned...",
//                    Lognumber = 1,
//                    PreferredTrackType = TrackType.Talk,
//                    Status = AbstractStatus.Assigned,
//                    AssignedSlot = "1001",
//                    NovelAspect = "It's interesting...",
//                    IsLocked = false,
//                    SubmittedDate = DateTime.Parse("2013-04-04"),
//                    PresentationDate = DateTime.Parse("2013-09-01"),
//                    ModifiedDate = DateTime.Parse("2013-09-01"),
//                    PublishDate = DateTime.Parse("2013-09-01"),
//                    UploadedFile = "myfile.pdf",
//                    UploadedFileStatus = FileStatus.Accepted,
//                    Authors = new List<AbstractUser>(),
//                    EntrySessions = new List<Session>(),
//                    Options = new List<AbstractOption>(),
//                    Session = sessions.FirstOrDefault(d => d.SessionId == 1),
//                    InmUser = users.FirstOrDefault(d => d.Email == "will.thomas@inmerge.com")
//                },
//                new Abstract
//                {
//                    Title = "My Second MVC app",
//                    Introduction = "I've studied for a long time...",
//                    Methods = "I worked really hard...",
//                    Results = "And this is what I learned...",
//                    Lognumber = 2,
//                    PreferredTrackType = TrackType.Talk,
//                    Status = AbstractStatus.Assigned,
//                    AssignedSlot = "1002",
//                    NovelAspect = "It's interesting...",
//                    IsLocked = false,
//                    SubmittedDate = DateTime.Parse("2013-04-04"),
//                    PresentationDate = DateTime.Parse("2013-09-01"),
//                    ModifiedDate = DateTime.Parse("2013-09-01"),
//                    PublishDate = DateTime.Parse("2013-09-01"),
//                    UploadedFile = "myfile.pdf",
//                    UploadedFileStatus = FileStatus.Accepted,
//                    Authors = new List<AbstractUser>(),
//                    EntrySessions = new List<Session>(),
//                    Options = new List<AbstractOption>(),
//                    Session = sessions.FirstOrDefault(d => d.SessionId == 2),
//                    InmUser = users.FirstOrDefault(d => d.Email == "will.thomas@inmerge.com")
//                },
//                new Abstract
//                {
//                    Title = "My Third MVC app",
//                    Introduction = "I've studied for a long time...",
//                    Methods = "I worked really hard...",
//                    Results = "And this is what I learned...",
//                    Lognumber = 3,
//                    PreferredTrackType = TrackType.Talk,
//                    Status = AbstractStatus.Assigned,
//                    AssignedSlot = "1003",
//                    NovelAspect = "It's interesting...",
//                    IsLocked = false,
//                    SubmittedDate = DateTime.Parse("2013-03-02"),
//                    PresentationDate = DateTime.Parse("2013-09-01"),
//                    ModifiedDate = DateTime.Parse("2013-09-01"),
//                    PublishDate = DateTime.Parse("2013-09-01"),
//                    UploadedFile = "myfile.pdf",
//                    UploadedFileStatus = FileStatus.Accepted,
//                    Authors = new List<AbstractUser>(),
//                    EntrySessions = new List<Session>(),
//                    Options = new List<AbstractOption>(),
//                    Session = sessions.FirstOrDefault(d => d.SessionId == 3),
//                    InmUser = users.FirstOrDefault(d => d.Email == "will.thomas@inmerge.com")
//                },
//                new Abstract
//                {
//                    Title = "My Forth MVC app",
//                    Introduction = "I've studied for a long time...",
//                    Methods = "I worked really hard...",
//                    Results = "And this is what I learned...",
//                    Lognumber = 4,
//                    PreferredTrackType = TrackType.Talk,
//                    Status = AbstractStatus.Assigned,
//                    AssignedSlot = "1004",
//                    NovelAspect = "It's interesting...",
//                    IsLocked = false,
//                    SubmittedDate = DateTime.Parse("2013-09-05"),
//                    PresentationDate = DateTime.Parse("2013-09-01"),
//                    ModifiedDate = DateTime.Parse("2013-09-01"),
//                    PublishDate = DateTime.Parse("2013-09-01"),
//                    UploadedFile = "myfile.pdf",
//                    UploadedFileStatus = FileStatus.Accepted,
//                    Authors = new List<AbstractUser>(),
//                    EntrySessions = new List<Session>(),
//                    Options = new List<AbstractOption>(),
//                    Session = sessions.FirstOrDefault(d => d.SessionId == 4),
//                    InmUser = users.FirstOrDefault(d => d.Email == "will.thomas@inmerge.com")
//                }
//            };

//            abstracts.ForEach(s => context.Abstracts.AddOrUpdate(p => p.AbstractId, s));
//            context.SaveChanges();

//            sessions[0].Abstracts.Add(abstracts[0]);
//            sessions[1].Abstracts.Add(abstracts[1]);
//            sessions[2].Abstracts.Add(abstracts[2]);
//            sessions[3].Abstracts.Add(abstracts[3]);
//            context.SaveChanges();

//            var abstractUser = new List<AbstractUser>
//            {
//                //3 authors per abstract for testing
//                //Abstract 1
//                new AbstractUser
//                {
//                    FirstName = "William",
//                    LastName = "Thomas",
//                    Email = "will.thomas@inmerge.com",
//                    Type = AbstractUserType.Presenter,
//                    Presenting = true,
//                    DisplayOrder = 1,
//                    hasAccount = true,
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 1),
//                    InmUser = users.FirstOrDefault(d => d.Email == "will.thomas@inmerge.com")
//                },
//                new AbstractUser
//                {
//                    FirstName = "Tom",
//                    LastName = "Thomas",
//                    Email = "tom.thomas@inmerge.com",
//                    Type = AbstractUserType.Author,
//                    Presenting = false,
//                    DisplayOrder = 2,
//                    hasAccount = true,
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 1),
//                    InmUser = users.FirstOrDefault(d => d.Email == "tom.thomas@inmerge.com")
//                },
//                new AbstractUser
//                {
//                    FirstName = "Carol",
//                    LastName = "Thomas",
//                    Email = "carol.thomas@inmerge.com",
//                    Type = AbstractUserType.Author,
//                    Presenting = false,
//                    DisplayOrder = 3,
//                    hasAccount = true,
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 1),
//                    InmUser = users.FirstOrDefault(d => d.Email == "carol.thomas@inmerge.com")
//                },
//                //Abstract 2
//                new AbstractUser
//                {
//                    FirstName = "William",
//                    LastName = "Thomas",
//                    Email = "will.thomas@inmerge.com",
//                    Type = AbstractUserType.Author,
//                    Presenting = false,
//                    DisplayOrder = 2,
//                    hasAccount = true,
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 2),
//                    InmUser = users.FirstOrDefault(d => d.Email == "will.thomas@inmerge.com")
//                },
//                new AbstractUser
//                {
//                    FirstName = "Tom",
//                    LastName = "Thomas",
//                    Email = "tom.thomas@inmerge.com",
//                    Type = AbstractUserType.Presenter,
//                    Presenting = true,
//                    DisplayOrder = 1,
//                    hasAccount = true,
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 2),
//                    InmUser = users.FirstOrDefault(d => d.Email == "tom.thomas@inmerge.com")
//                },
//                new AbstractUser
//                {
//                    FirstName = "Carol",
//                    LastName = "Thomas",
//                    Email = "carol.thomas@inmerge.com",
//                    Type = AbstractUserType.Author,
//                    Presenting = false,
//                    DisplayOrder = 3,
//                    hasAccount = true,
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 2),
//                    InmUser = users.FirstOrDefault(d => d.Email == "carol.thomas@inmerge.com")
//                },
//                //Abstract 3
//                new AbstractUser
//                {
//                    FirstName = "William",
//                    LastName = "Thomas",
//                    Email = "will.thomas@inmerge.com",
//                    Type = AbstractUserType.Author,
//                    Presenting = false,
//                    DisplayOrder = 3,
//                    hasAccount = true,
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 3),
//                    InmUser = users.FirstOrDefault(d => d.Email == "will.thomas@inmerge.com")
//                },
//                new AbstractUser
//                {
//                    FirstName = "Tom",
//                    LastName = "Thomas",
//                    Email = "tom.thomas@inmerge.com",
//                    Type = AbstractUserType.Author,
//                    Presenting = false,
//                    DisplayOrder = 2,
//                    hasAccount = true,
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 3),
//                    InmUser = users.FirstOrDefault(d => d.Email == "tom.thomas@inmerge.com")
//                },
//                new AbstractUser
//                {
//                    FirstName = "Carol",
//                    LastName = "Thomas",
//                    Email = "carol.thomas@inmerge.com",
//                    Type = AbstractUserType.Presenter,
//                    Presenting = true,
//                    DisplayOrder = 1,
//                    hasAccount = true,
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 3),
//                    InmUser = users.FirstOrDefault(d => d.Email == "carol.thomas@inmerge.com")
//                },
//                //Abstract 4
//                new AbstractUser
//                {
//                    FirstName = "William",
//                    LastName = "Thomas",
//                    Email = "will.thomas@inmerge.com",
//                    Type = AbstractUserType.Presenter,
//                    Presenting = true,
//                    DisplayOrder = 1,
//                    hasAccount = true,
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 4),
//                    InmUser = users.FirstOrDefault(d => d.Email == "will.thomas@inmerge.com")
//                },
//                new AbstractUser
//                {
//                    FirstName = "Tom",
//                    LastName = "Thomas",
//                    Email = "tom.thomas@inmerge.com",
//                    Type = AbstractUserType.Author,
//                    Presenting = false,
//                    DisplayOrder = 2,
//                    hasAccount = true,
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 4),
//                    InmUser = users.FirstOrDefault(d => d.Email == "tom.thomas@inmerge.com")
//                },
//                new AbstractUser
//                {
//                    FirstName = "Carol",
//                    LastName = "Thomas",
//                    Email = "carol.thomas@inmerge.com",
//                    Type = AbstractUserType.Author,
//                    Presenting = false,
//                    DisplayOrder = 3,
//                    hasAccount = true,
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 4),
//                    InmUser = users.FirstOrDefault(d => d.Email == "carol.thomas@inmerge.com")
//                },
//            };

//            abstractUser.ForEach(s => context.AbstractUsers.AddOrUpdate(p => p.AbstractUserId, s));
//            context.SaveChanges();

//            //add users to abstract 1
//            abstracts[0].Authors.Add(abstractUser[0]);
//            abstracts[0].Authors.Add(abstractUser[1]);
//            abstracts[0].Authors.Add(abstractUser[2]);

//            //add users to abstract 2
//            abstracts[1].Authors.Add(abstractUser[3]);
//            abstracts[1].Authors.Add(abstractUser[4]);
//            abstracts[1].Authors.Add(abstractUser[5]);

//            //add users to abstract 3
//            abstracts[2].Authors.Add(abstractUser[6]);
//            abstracts[2].Authors.Add(abstractUser[7]);
//            abstracts[2].Authors.Add(abstractUser[8]);

//            //add users to abstract 4
//            abstracts[3].Authors.Add(abstractUser[9]);
//            abstracts[3].Authors.Add(abstractUser[10]);
//            abstracts[3].Authors.Add(abstractUser[11]);
//            context.SaveChanges();


//            var abstractOption = new List<AbstractOption>
//            {
////5 options per abstrasct
//                //Abstract 1
//                new AbstractOption
//                {
//                    Answer = "true",
//                    Option = options.FirstOrDefault(d => d.OptionId == 1),
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 1)
//                },
//                new AbstractOption
//                {
//                    Answer = "false",
//                    Option = options.FirstOrDefault(d => d.OptionId == 2),
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 1)
//                },
//                new AbstractOption
//                {
//                    Answer = "blue",
//                    Option = options.FirstOrDefault(d => d.OptionId == 3),
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 1)
//                },
//                new AbstractOption
//                {
//                    Answer = "true",
//                    Option = options.FirstOrDefault(d => d.OptionId == 4),
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 1)
//                },
//                new AbstractOption
//                {
//                    Answer = "Einstein",
//                    Option = options.FirstOrDefault(d => d.OptionId == 5),
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 1)
//                },
//                //Abstract 2
//                new AbstractOption
//                {
//                    Answer = "true",
//                    Option = options.FirstOrDefault(d => d.OptionId == 1),
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 2)
//                },
//                new AbstractOption
//                {
//                    Answer = "false",
//                    Option = options.FirstOrDefault(d => d.OptionId == 2),
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 2)
//                },
//                new AbstractOption
//                {
//                    Answer = "blue",
//                    Option = options.FirstOrDefault(d => d.OptionId == 3),
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 2)
//                },
//                new AbstractOption
//                {
//                    Answer = "false",
//                    Option = options.FirstOrDefault(d => d.OptionId == 4),
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 2)
//                },
//                new AbstractOption
//                {
//                    Answer = "",
//                    Option = options.FirstOrDefault(d => d.OptionId == 5),
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 2)
//                },
//                //Abstract 3
//                new AbstractOption
//                {
//                    Answer = "true",
//                    Option = options.FirstOrDefault(d => d.OptionId == 1),
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 3)
//                },
//                new AbstractOption
//                {
//                    Answer = "false",
//                    Option = options.FirstOrDefault(d => d.OptionId == 2),
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 3)
//                },
//                new AbstractOption
//                {
//                    Answer = "blue",
//                    Option = options.FirstOrDefault(d => d.OptionId == 3),
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 3)
//                },
//                new AbstractOption
//                {
//                    Answer = "true",
//                    Option = options.FirstOrDefault(d => d.OptionId == 4),
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 3)
//                },
//                new AbstractOption
//                {
//                    Answer = "Socrotes",
//                    Option = options.FirstOrDefault(d => d.OptionId == 5),
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 3)
//                },
//                //Abstract 4
//                new AbstractOption
//                {
//                    Answer = "true",
//                    Option = options.FirstOrDefault(d => d.OptionId == 1),
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 4)
//                },
//                new AbstractOption
//                {
//                    Answer = "false",
//                    Option = options.FirstOrDefault(d => d.OptionId == 2),
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 4)
//                },
//                new AbstractOption
//                {
//                    Answer = "blue",
//                    Option = options.FirstOrDefault(d => d.OptionId == 3),
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 4)
//                },
//                new AbstractOption
//                {
//                    Answer = "false",
//                    Option = options.FirstOrDefault(d => d.OptionId == 4),
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 4)
//                },
//                new AbstractOption
//                {
//                    Answer = "",
//                    Option = options.FirstOrDefault(d => d.OptionId == 5),
//                    Abstract = abstracts.FirstOrDefault(d => d.AbstractId == 4)
//                },
//            };

//            abstractOption.ForEach(s => context.AbstractOptions.AddOrUpdate(p => p.AbstractOptionId, s));
//            context.SaveChanges();

//            //add users to abstract 1
//            abstracts[0].Options.Add(abstractOption[0]);
//            abstracts[0].Options.Add(abstractOption[1]);
//            abstracts[0].Options.Add(abstractOption[2]);
//            abstracts[0].Options.Add(abstractOption[3]);
//            abstracts[0].Options.Add(abstractOption[4]);

//            //add users to abstract 2
//            abstracts[1].Options.Add(abstractOption[5]);
//            abstracts[1].Options.Add(abstractOption[6]);
//            abstracts[1].Options.Add(abstractOption[7]);
//            abstracts[1].Options.Add(abstractOption[8]);
//            abstracts[1].Options.Add(abstractOption[9]);

//            //add users to abstract 3
//            abstracts[2].Options.Add(abstractOption[10]);
//            abstracts[2].Options.Add(abstractOption[11]);
//            abstracts[2].Options.Add(abstractOption[12]);
//            abstracts[2].Options.Add(abstractOption[13]);
//            abstracts[2].Options.Add(abstractOption[14]);

//            //add users to abstract 4
//            abstracts[3].Options.Add(abstractOption[15]);
//            abstracts[3].Options.Add(abstractOption[16]);
//            abstracts[3].Options.Add(abstractOption[17]);
//            abstracts[3].Options.Add(abstractOption[18]);
//            abstracts[3].Options.Add(abstractOption[19]);
//            context.SaveChanges();


//            //Add entry sessions to Abstract  add a final session?
//            //Research asp.net identity further, decide on best manner to link tables


            base.Seed(context);


        }
    }
}
