namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddManufacturerData : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE ToolCategories SET ToolType = 'DEWALT' WHERE Id = 1");
            Sql("UPDATE ToolCategories SET ToolType = 'RYOBI' WHERE Id = 2");
            Sql("UPDATE ToolCategories SET ToolType = 'CRAFTSMAN' WHERE Id = 3");
            Sql("UPDATE ToolCategories SET ToolType = 'SNAP ON' WHERE Id = 4");
            Sql("UPDATE ToolCategories SET ToolType = 'MILWAUKEE' WHERE Id = 5");
            Sql("UPDATE ToolCategories SET ToolType = 'MATCO' WHERE Id = 6");
            Sql("UPDATE ToolCategories SET ToolType = 'TRUE VALUE' WHERE Id = 7");
            Sql("UPDATE ToolCategories SET ToolType = 'MAC TOOLS' WHERE Id = 8");


        }

        public override void Down()
        {
        }
    }
}
