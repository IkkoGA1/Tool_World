namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddManufacturerModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ManufacturerName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Tools", "DriveSize", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tools", "DriveSize");
            DropTable("dbo.Manufacturers");
        }
    }
}
