namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberInStkAndAvailToTool : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tools", "NumberInStock", c => c.Byte(nullable: false));
            AddColumn("dbo.Tools", "NumberAvailable", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tools", "NumberAvailable");
            DropColumn("dbo.Tools", "NumberInStock");
        }
    }
}
