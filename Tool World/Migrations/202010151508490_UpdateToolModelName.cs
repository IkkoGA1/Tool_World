namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateToolModelName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tools", "ModelName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tools", "ModelName");
        }
    }
}
