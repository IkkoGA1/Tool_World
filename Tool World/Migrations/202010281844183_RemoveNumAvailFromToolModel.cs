namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveNumAvailFromToolModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Tools", "NumberAvailable");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tools", "NumberAvailable", c => c.Byte(nullable: false));
        }
    }
}
