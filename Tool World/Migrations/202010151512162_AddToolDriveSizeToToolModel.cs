namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddToolDriveSizeToToolModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tools", "ToolDriveSize_Id", c => c.Int());
            CreateIndex("dbo.Tools", "ToolDriveSize_Id");
            AddForeignKey("dbo.Tools", "ToolDriveSize_Id", "dbo.ToolDriveSizes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tools", "ToolDriveSize_Id", "dbo.ToolDriveSizes");
            DropIndex("dbo.Tools", new[] { "ToolDriveSize_Id" });
            DropColumn("dbo.Tools", "ToolDriveSize_Id");
        }
    }
}
