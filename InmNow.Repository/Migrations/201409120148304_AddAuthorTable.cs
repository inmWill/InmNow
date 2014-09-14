namespace InmNow.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAuthorTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Author",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 150),
                        LastName = c.String(maxLength: 150),
                        Email = c.String(maxLength: 150),
                        Phone = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.AuthorId);
            
            AlterColumn("dbo.Client", "ClientId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Client", "ClientId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Client");
            AlterColumn("dbo.Client", "ClientId", c => c.Int(nullable: false));
            DropTable("dbo.Author");
            AddPrimaryKey("dbo.Client", "ClientId");
        }
    }
}
