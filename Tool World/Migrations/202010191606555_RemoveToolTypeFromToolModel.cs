namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveToolTypeFromToolModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tools", "ToolCategoryId", "dbo.ToolCategories");
            DropForeignKey("dbo.Tools", "ToolType_Id", "dbo.ToolCategories");
            DropIndex("dbo.Tools", new[] { "ToolCategoryId" });
            DropIndex("dbo.Tools", new[] { "ToolType_Id" });
            DropColumn("dbo.Tools", "ToolCategoryId");
            RenameColumn(table: "dbo.Tools", name: "ToolTypeId", newName: "ToolCategoryId");
            AlterColumn("dbo.Tools", "ToolCategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Tools", "ToolCategoryId");
            AddForeignKey("dbo.Tools", "ToolCategoryId", "dbo.ToolCategories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tools", "ToolCategoryId", "dbo.ToolCategories");
            DropIndex("dbo.Tools", new[] { "ToolCategoryId" });
            AlterColumn("dbo.Tools", "ToolCategoryId", c => c.Int());
            RenameColumn(table: "dbo.Tools", name: "ToolCategoryId", newName: "ToolType_Id");
            AddColumn("dbo.Tools", "ToolCategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Tools", "ToolTypeId");
            CreateIndex("dbo.Tools", "ToolCategoryId");
            AddForeignKey("dbo.Tools", "ToolTypeId", "dbo.ToolCategories", "Id");
            AddForeignKey("dbo.Tools", "ToolCategoryId", "dbo.ToolCategories", "Id", cascadeDelete: true);
        }
    }
}
