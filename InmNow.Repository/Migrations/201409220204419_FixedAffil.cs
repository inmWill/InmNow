namespace InmNow.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedAffil : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Affiliation", "UserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Affiliation", "UserId", c => c.String(maxLength: 128));
        }
    }
}
