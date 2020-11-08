namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveToolCategoryOnManufacturer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Manufacturers", "ToolCategory_Id", "dbo.ToolCategories");
            DropIndex("dbo.Manufacturers", new[] { "ToolCategory_Id" });
            DropColumn("dbo.Manufacturers", "ToolCategory_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Manufacturers", "ToolCategory_Id", c => c.Int());
            CreateIndex("dbo.Manufacturers", "ToolCategory_Id");
            AddForeignKey("dbo.Manufacturers", "ToolCategory_Id", "dbo.ToolCategories", "Id");
        }
    }
}
