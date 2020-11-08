namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRntlStatusToRentalMdl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rentals", "IsRentalActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rentals", "IsRentalActive");
        }
    }
}
