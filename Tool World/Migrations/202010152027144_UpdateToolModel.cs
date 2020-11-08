namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateToolModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tools", "Manufacturer_Id", "dbo.Manufacturers");
            DropForeignKey("dbo.Tools", "ToolCategory_Id", "dbo.ToolCategories");
            DropForeignKey("dbo.Tools", "ToolDriveSize_Id", "dbo.ToolDriveSizes");
            DropIndex("dbo.Tools", new[] { "Manufacturer_Id" });
            DropIndex("dbo.Tools", new[] { "ToolCategory_Id" });
            DropIndex("dbo.Tools", new[] { "ToolDriveSize_Id" });
            RenameColumn(table: "dbo.Tools", name: "Manufacturer_Id", newName: "ManufacturerId");
            RenameColumn(table: "dbo.Tools", name: "ToolCategory_Id", newName: "ToolCategoryId");
            RenameColumn(table: "dbo.Tools", name: "ToolDriveSize_Id", newName: "ToolDriveSizeId");
            AlterColumn("dbo.Tools", "ManufacturerId", c => c.Int(nullable: false));
            AlterColumn("dbo.Tools", "ToolCategoryId", c => c.Int(nullable: false));
            AlterColumn("dbo.Tools", "ToolDriveSizeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Tools", "ManufacturerId");
            CreateIndex("dbo.Tools", "ToolCategoryId");
            CreateIndex("dbo.Tools", "ToolDriveSizeId");
            AddForeignKey("dbo.Tools", "ManufacturerId", "dbo.Manufacturers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Tools", "ToolCategoryId", "dbo.ToolCategories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Tools", "ToolDriveSizeId", "dbo.ToolDriveSizes", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tools", "ToolDriveSizeId", "dbo.ToolDriveSizes");
            DropForeignKey("dbo.Tools", "ToolCategoryId", "dbo.ToolCategories");
            DropForeignKey("dbo.Tools", "ManufacturerId", "dbo.Manufacturers");
            DropIndex("dbo.Tools", new[] { "ToolDriveSizeId" });
            DropIndex("dbo.Tools", new[] { "ToolCategoryId" });
            DropIndex("dbo.Tools", new[] { "ManufacturerId" });
            AlterColumn("dbo.Tools", "ToolDriveSizeId", c => c.Int());
            AlterColumn("dbo.Tools", "ToolCategoryId", c => c.Int());
            AlterColumn("dbo.Tools", "ManufacturerId", c => c.Int());
            RenameColumn(table: "dbo.Tools", name: "ToolDriveSizeId", newName: "ToolDriveSize_Id");
            RenameColumn(table: "dbo.Tools", name: "ToolCategoryId", newName: "ToolCategory_Id");
            RenameColumn(table: "dbo.Tools", name: "ManufacturerId", newName: "Manufacturer_Id");
            CreateIndex("dbo.Tools", "ToolDriveSize_Id");
            CreateIndex("dbo.Tools", "ToolCategory_Id");
            CreateIndex("dbo.Tools", "Manufacturer_Id");
            AddForeignKey("dbo.Tools", "ToolDriveSize_Id", "dbo.ToolDriveSizes", "Id");
            AddForeignKey("dbo.Tools", "ToolCategory_Id", "dbo.ToolCategories", "Id");
            AddForeignKey("dbo.Tools", "Manufacturer_Id", "dbo.Manufacturers", "Id");
        }
    }
}
