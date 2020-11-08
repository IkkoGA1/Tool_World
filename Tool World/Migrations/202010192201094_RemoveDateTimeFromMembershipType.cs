namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDateTimeFromMembershipType : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MembershipTypes", "DateTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "DateTime", c => c.DateTime(nullable: false));
        }
    }
}
