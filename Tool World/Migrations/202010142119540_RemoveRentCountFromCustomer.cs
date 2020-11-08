namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveRentCountFromCustomer : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "CustomerRentCount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CustomerRentCount", c => c.Int(nullable: false));
        }
    }
}
