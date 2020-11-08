namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddToolSizeData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ToolDriveSizes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Drive = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ToolDriveSizes");
        }
    }
}
