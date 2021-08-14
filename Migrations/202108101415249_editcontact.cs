namespace Maintainance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editcontact : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Contacts", "SiteName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "SiteName", c => c.String());
        }
    }
}
