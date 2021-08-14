namespace Maintainance.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatework : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OurWorks", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.OurWorks", "Image");
        }
    }
}
