namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberAvailBackToToolMdl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tools", "NumberAvailable", c => c.Byte(nullable: false));

            Sql("UPDATE Tools SET NumberAvailable = NumberInStock");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tools", "NumberAvailable");
        }
    }
}
