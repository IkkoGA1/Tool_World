namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddToolCategoriesData : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE ToolCategories SET ToolType = 'CORDLESS ELECTRIC IMPACT' WHERE Id = 1");
            Sql("UPDATE ToolCategories SET ToolType = 'PNEUMATIC IMPACT' WHERE Id = 2");
            Sql("UPDATE ToolCategories SET ToolType = 'CONCRETE MIXER' WHERE Id = 3");
            Sql("UPDATE ToolCategories SET ToolType = 'CORDLESS ELECTRIC DRILL' WHERE Id = 4");
            Sql("UPDATE ToolCategories SET ToolType = 'PRESSURE WASHER' WHERE Id = 5");
            Sql("UPDATE ToolCategories SET ToolType = 'DRAIN SNAKE' WHERE Id = 6");
            Sql("UPDATE ToolCategories SET ToolType = 'LADDER' WHERE Id = 7");
            Sql("UPDATE ToolCategories SET ToolType = 'PNEUMATIC PAINT SPRAYER' WHERE Id = 8");
            Sql("UPDATE ToolCategories SET ToolType = 'ELECTRIC PAINT SPRAYER' WHERE Id = 9");
            Sql("UPDATE ToolCategories SET ToolType = 'CORDED HEAVY DUTY DRILL' WHERE Id = 10");
            Sql("UPDATE ToolCategories SET ToolType = 'PNEUMATIC NAIL GUN' WHERE Id = 11");
            Sql("UPDATE ToolCategories SET ToolType = 'ELECTRIC NAIL GUN' WHERE Id = 12");
            Sql("UPDATE ToolCategories SET ToolType = 'JACK HAMMER' WHERE Id = 13");
            Sql("UPDATE ToolCategories SET ToolType = 'AIR COMPRESSOR' WHERE Id = 14");
            Sql("UPDATE ToolCategories SET ToolType = 'BAND SAW' WHERE Id = 15");
            Sql("UPDATE ToolCategories SET ToolType = 'FENCE POST DRIVER' WHERE Id = 16");
            Sql("UPDATE ToolCategories SET ToolType = 'TILE SAW' WHERE Id = 17");
            Sql("UPDATE ToolCategories SET ToolType = 'GARDEN TILLER' WHERE Id = 18");
            Sql("UPDATE ToolCategories SET ToolType = 'DIAMOND SAW BLADE' WHERE Id = 19");
            Sql("UPDATE ToolCategories SET ToolType = 'HARDWOOD INSTALLER' WHERE Id = 20");
        }
        
        public override void Down()
        {
        }
    }
}
