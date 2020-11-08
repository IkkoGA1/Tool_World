namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AnnotateUrlLinkInToolMdl : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tools", "UrlPicLink", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tools", "UrlPicLink", c => c.String());
        }
    }
}
