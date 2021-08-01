namespace Maintainance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Contacts21 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PhonNumber = c.String(nullable: false),
                        Email = c.String(),
                        SiteName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.OurWorks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Description = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OurWorks");
            DropTable("dbo.Contacts");
        }
    }
}
