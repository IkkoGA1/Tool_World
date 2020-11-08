namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddToolTypeToToolModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tools", "ToolType_Id", c => c.Int());
            CreateIndex("dbo.Tools", "ToolType_Id");
            AddForeignKey("dbo.Tools", "ToolType_Id", "dbo.ToolCategories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tools", "ToolType_Id", "dbo.ToolCategories");
            DropIndex("dbo.Tools", new[] { "ToolType_Id" });
            DropColumn("dbo.Tools", "ToolType_Id");
        }
    }
}
