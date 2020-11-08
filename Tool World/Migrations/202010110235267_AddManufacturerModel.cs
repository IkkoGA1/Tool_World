namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddManufacturerModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tools", "DriveSize", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tools", "DriveSize");
        }
    }
}
