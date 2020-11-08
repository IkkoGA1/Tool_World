namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedNotNeededFieldsFromToolModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tools", "Name");
            DropColumn("dbo.Tools", "DriveSize");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tools", "DriveSize", c => c.String());
            AddColumn("dbo.Tools", "Name", c => c.String());
        }
    }
}
