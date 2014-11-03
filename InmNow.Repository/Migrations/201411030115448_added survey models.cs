namespace InmNow.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedsurveymodels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Surveys",
                c => new
                    {
                        SurveyId = c.Int(nullable: false, identity: true),
                        SurveyName = c.String(),
                        Instructions = c.String(),
                        OtherInfo = c.String(),
                        IsRequired = c.Boolean(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        ClientId = c.Int(nullable: false),
                        ModifiedById = c.Int(),
                        AddedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        IpAddress = c.String(),
                    })
                .PrimaryKey(t => t.SurveyId)
                .ForeignKey("dbo.Client", t => t.ClientId, cascadeDelete: true)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        QuestionId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        QuestionText = c.String(),
                        QuestionSubText = c.String(),
                        Type = c.Int(nullable: false),
                        Required = c.Boolean(nullable: false),
                        SurveyId = c.Int(nullable: false),
                        ModifiedById = c.Int(),
                        AddedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        IpAddress = c.String(),
                    })
                .PrimaryKey(t => t.QuestionId)
                .ForeignKey("dbo.Surveys", t => t.SurveyId, cascadeDelete: true)
                .Index(t => t.SurveyId);
            
            CreateTable(
                "dbo.Dialogs",
                c => new
                    {
                        DialogId = c.Int(nullable: false, identity: true),
                        PromptingQuestionId = c.Int(nullable: false),
                        RespondingQuestionId = c.Int(nullable: false),
                        TriggerOnBool = c.Boolean(),
                        TriggerOnPhrase = c.String(),
                        TriggerOnDecimalLow = c.Decimal(precision: 18, scale: 2),
                        TriggerOnDecimalHigh = c.Decimal(precision: 18, scale: 2),
                        ModifiedById = c.Int(),
                        AddedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        IpAddress = c.String(),
                        Question_QuestionId = c.Int(),
                    })
                .PrimaryKey(t => t.DialogId)
                .ForeignKey("dbo.Questions", t => t.Question_QuestionId)
                .Index(t => t.Question_QuestionId);
            
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        AnswerId = c.Int(nullable: false, identity: true),
                        TextAnswer = c.String(),
                        BooleanAnswer = c.Boolean(),
                        DecimalAnswer = c.Decimal(nullable: false, precision: 18, scale: 2),
                        QuestionId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        ModifiedById = c.Int(),
                        AddedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        IpAddress = c.String(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.AnswerId)
                .ForeignKey("dbo.Questions", t => t.QuestionId, cascadeDelete: true)
                .ForeignKey("dbo.InmUser", t => t.User_Id)
                .Index(t => t.QuestionId)
                .Index(t => t.User_Id);
            
            AddColumn("dbo.Affiliation", "Postal", c => c.String());
            AddColumn("dbo.Affiliation", "Unit", c => c.String());
            AddColumn("dbo.Affiliation", "Region", c => c.String());
            AddColumn("dbo.Affiliation", "Postal1", c => c.String());
            AddColumn("dbo.Affiliation", "ModifiedById", c => c.Int());
            AddColumn("dbo.Affiliation", "AddedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Affiliation", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Affiliation", "IpAddress", c => c.String());
            AddColumn("dbo.Author", "ModifiedById", c => c.Int());
            AddColumn("dbo.Author", "AddedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Author", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Author", "IpAddress", c => c.String());
            AddColumn("dbo.Client", "Description", c => c.String());
            AddColumn("dbo.Client", "Contact", c => c.String());
            AddColumn("dbo.Client", "Website", c => c.String(maxLength: 150));
            AddColumn("dbo.Client", "Active", c => c.Boolean(nullable: false));
            AddColumn("dbo.Client", "ModifiedById", c => c.Int());
            AddColumn("dbo.Client", "AddedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Client", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Client", "IpAddress", c => c.String());
            AddColumn("dbo.InmAbstractAuthor", "ModifiedById", c => c.Int());
            AddColumn("dbo.InmAbstractAuthor", "AddedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.InmAbstractAuthor", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.InmAbstractAuthor", "IpAddress", c => c.String());
            AddColumn("dbo.InmAbstractOption", "ModifiedById", c => c.Int());
            AddColumn("dbo.InmAbstractOption", "AddedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.InmAbstractOption", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.InmAbstractOption", "IpAddress", c => c.String());
            AddColumn("dbo.InmAbstract", "ModifiedById", c => c.Int());
            AddColumn("dbo.InmAbstract", "AddedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.InmAbstract", "IpAddress", c => c.String());
            AddColumn("dbo.InmUser", "Survey_SurveyId", c => c.Int());
            AddColumn("dbo.InmUser", "Client_ClientId", c => c.Int());
            AddColumn("dbo.InmUser", "Street", c => c.String());
            AddColumn("dbo.InmUser", "Unit", c => c.String());
            AddColumn("dbo.InmUser", "Postal", c => c.String());
            AddColumn("dbo.Meeting", "ModifiedById", c => c.Int());
            AddColumn("dbo.Meeting", "AddedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Meeting", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Meeting", "IpAddress", c => c.String());
            AddColumn("dbo.Option", "ModifiedById", c => c.Int());
            AddColumn("dbo.Option", "AddedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Option", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Option", "IpAddress", c => c.String());
            AddColumn("dbo.Session", "ModifiedById", c => c.Int());
            AddColumn("dbo.Session", "AddedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Session", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Session", "IpAddress", c => c.String());
            AddColumn("dbo.Track", "ModifiedById", c => c.Int());
            AddColumn("dbo.Track", "AddedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Track", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Track", "IpAddress", c => c.String());
            CreateIndex("dbo.InmUser", "Survey_SurveyId");
            CreateIndex("dbo.InmUser", "Client_ClientId");
            AddForeignKey("dbo.InmUser", "Survey_SurveyId", "dbo.Surveys", "SurveyId");
            AddForeignKey("dbo.InmUser", "Client_ClientId", "dbo.Client", "ClientId");
            DropColumn("dbo.Affiliation", "Address");
            DropColumn("dbo.Client", "URL");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Client", "URL", c => c.String(maxLength: 150));
            AddColumn("dbo.Affiliation", "Address", c => c.String());
            DropForeignKey("dbo.InmUser", "Client_ClientId", "dbo.Client");
            DropForeignKey("dbo.InmUser", "Survey_SurveyId", "dbo.Surveys");
            DropForeignKey("dbo.Answers", "User_Id", "dbo.InmUser");
            DropForeignKey("dbo.Answers", "QuestionId", "dbo.Questions");
            DropForeignKey("dbo.Questions", "SurveyId", "dbo.Surveys");
            DropForeignKey("dbo.Dialogs", "Question_QuestionId", "dbo.Questions");
            DropForeignKey("dbo.Surveys", "ClientId", "dbo.Client");
            DropIndex("dbo.InmUser", new[] { "Client_ClientId" });
            DropIndex("dbo.InmUser", new[] { "Survey_SurveyId" });
            DropIndex("dbo.Answers", new[] { "User_Id" });
            DropIndex("dbo.Answers", new[] { "QuestionId" });
            DropIndex("dbo.Dialogs", new[] { "Question_QuestionId" });
            DropIndex("dbo.Questions", new[] { "SurveyId" });
            DropIndex("dbo.Surveys", new[] { "ClientId" });
            DropColumn("dbo.Track", "IpAddress");
            DropColumn("dbo.Track", "ModifiedDate");
            DropColumn("dbo.Track", "AddedDate");
            DropColumn("dbo.Track", "ModifiedById");
            DropColumn("dbo.Session", "IpAddress");
            DropColumn("dbo.Session", "ModifiedDate");
            DropColumn("dbo.Session", "AddedDate");
            DropColumn("dbo.Session", "ModifiedById");
            DropColumn("dbo.Option", "IpAddress");
            DropColumn("dbo.Option", "ModifiedDate");
            DropColumn("dbo.Option", "AddedDate");
            DropColumn("dbo.Option", "ModifiedById");
            DropColumn("dbo.Meeting", "IpAddress");
            DropColumn("dbo.Meeting", "ModifiedDate");
            DropColumn("dbo.Meeting", "AddedDate");
            DropColumn("dbo.Meeting", "ModifiedById");
            DropColumn("dbo.InmUser", "Postal");
            DropColumn("dbo.InmUser", "Unit");
            DropColumn("dbo.InmUser", "Street");
            DropColumn("dbo.InmUser", "Client_ClientId");
            DropColumn("dbo.InmUser", "Survey_SurveyId");
            DropColumn("dbo.InmAbstract", "IpAddress");
            DropColumn("dbo.InmAbstract", "AddedDate");
            DropColumn("dbo.InmAbstract", "ModifiedById");
            DropColumn("dbo.InmAbstractOption", "IpAddress");
            DropColumn("dbo.InmAbstractOption", "ModifiedDate");
            DropColumn("dbo.InmAbstractOption", "AddedDate");
            DropColumn("dbo.InmAbstractOption", "ModifiedById");
            DropColumn("dbo.InmAbstractAuthor", "IpAddress");
            DropColumn("dbo.InmAbstractAuthor", "ModifiedDate");
            DropColumn("dbo.InmAbstractAuthor", "AddedDate");
            DropColumn("dbo.InmAbstractAuthor", "ModifiedById");
            DropColumn("dbo.Client", "IpAddress");
            DropColumn("dbo.Client", "ModifiedDate");
            DropColumn("dbo.Client", "AddedDate");
            DropColumn("dbo.Client", "ModifiedById");
            DropColumn("dbo.Client", "Active");
            DropColumn("dbo.Client", "Website");
            DropColumn("dbo.Client", "Contact");
            DropColumn("dbo.Client", "Description");
            DropColumn("dbo.Author", "IpAddress");
            DropColumn("dbo.Author", "ModifiedDate");
            DropColumn("dbo.Author", "AddedDate");
            DropColumn("dbo.Author", "ModifiedById");
            DropColumn("dbo.Affiliation", "IpAddress");
            DropColumn("dbo.Affiliation", "ModifiedDate");
            DropColumn("dbo.Affiliation", "AddedDate");
            DropColumn("dbo.Affiliation", "ModifiedById");
            DropColumn("dbo.Affiliation", "Postal1");
            DropColumn("dbo.Affiliation", "Region");
            DropColumn("dbo.Affiliation", "Unit");
            DropColumn("dbo.Affiliation", "Postal");
            DropTable("dbo.Answers");
            DropTable("dbo.Dialogs");
            DropTable("dbo.Questions");
            DropTable("dbo.Surveys");
        }
    }
}
