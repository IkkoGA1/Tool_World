namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveAddressFromCustomer : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Address", c => c.String());
        }
    }
}
