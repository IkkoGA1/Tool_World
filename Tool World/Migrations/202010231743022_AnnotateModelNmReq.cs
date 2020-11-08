namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnnotateModelNmReq : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tools", "ModelName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tools", "ModelName", c => c.String());
        }
    }
}
