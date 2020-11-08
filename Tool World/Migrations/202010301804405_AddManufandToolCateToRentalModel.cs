namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddManufandToolCateToRentalModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "Manufacturer_Id", c => c.Int());
            AddColumn("dbo.Rentals", "ToolCategory_Id", c => c.Int());
            AddColumn("dbo.Rentals", "ToolDriveSize_Id", c => c.Int());
            CreateIndex("dbo.Rentals", "Manufacturer_Id");
            CreateIndex("dbo.Rentals", "ToolCategory_Id");
            CreateIndex("dbo.Rentals", "ToolDriveSize_Id");
            AddForeignKey("dbo.Rentals", "Manufacturer_Id", "dbo.Manufacturers", "Id");
            AddForeignKey("dbo.Rentals", "ToolCategory_Id", "dbo.ToolCategories", "Id");
            AddForeignKey("dbo.Rentals", "ToolDriveSize_Id", "dbo.ToolDriveSizes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rentals", "ToolDriveSize_Id", "dbo.ToolDriveSizes");
            DropForeignKey("dbo.Rentals", "ToolCategory_Id", "dbo.ToolCategories");
            DropForeignKey("dbo.Rentals", "Manufacturer_Id", "dbo.Manufacturers");
            DropIndex("dbo.Rentals", new[] { "ToolDriveSize_Id" });
            DropIndex("dbo.Rentals", new[] { "ToolCategory_Id" });
            DropIndex("dbo.Rentals", new[] { "Manufacturer_Id" });
            DropColumn("dbo.Rentals", "ToolDriveSize_Id");
            DropColumn("dbo.Rentals", "ToolCategory_Id");
            DropColumn("dbo.Rentals", "Manufacturer_Id");
        }
    }
}
