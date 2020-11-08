namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddToolCategory : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ToolCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ToolType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ToolCategories");
        }
    }
}
