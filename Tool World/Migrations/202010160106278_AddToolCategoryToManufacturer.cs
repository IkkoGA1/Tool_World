namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddToolCategoryToManufacturer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Manufacturers", "ToolCategory_Id", c => c.Int());
            CreateIndex("dbo.Manufacturers", "ToolCategory_Id");
            AddForeignKey("dbo.Manufacturers", "ToolCategory_Id", "dbo.ToolCategories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Manufacturers", "ToolCategory_Id", "dbo.ToolCategories");
            DropIndex("dbo.Manufacturers", new[] { "ToolCategory_Id" });
            DropColumn("dbo.Manufacturers", "ToolCategory_Id");
        }
    }
}
