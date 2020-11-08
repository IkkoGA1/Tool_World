namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddToolSizeData1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE ToolDriveSizes SET Drive = '1/4 in.' WHERE Id = 1");
            Sql("UPDATE ToolDriveSizes SET Drive = '3/8 in.' WHERE Id = 2");
            Sql("UPDATE ToolDriveSizes SET Drive = '1/2 in.' WHERE Id = 3");
            Sql("UPDATE ToolDriveSizes SET Drive = '3/4 in' WHERE Id = 4");
            Sql("UPDATE ToolDriveSizes SET Drive = '1 in.' WHERE Id = 5");
        }
        
        public override void Down()
        {
        }
    }
}
