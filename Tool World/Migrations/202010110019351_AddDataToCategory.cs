namespace Tool_World.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToCategory : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Category(Id, ToolType) VALUES(1, 'CORDLESS ELECTRIC IMPACT')");
            Sql("INSERT INTO Category(Id, ToolType) VALUES(2, 'PNEUMATIC IMPACT')");
            Sql("INSERT INTO Category(Id, ToolType) VALUES(3, 'CONCRETE MIXER')");
            Sql("INSERT INTO Category(Id, ToolType) VALUES(4, 'CORDLESS ELECTRIC DRILL')");
            Sql("INSERT INTO Category(Id, ToolType) VALUES(5, 'PRESSURE WASHER')");
            Sql("INSERT INTO Category(Id, ToolType) VALUES(6, 'DRAIN SNAKE')");
            Sql("INSERT INTO Category(Id, ToolType) VALUES(7, 'LADDER')");
            Sql("INSERT INTO Category(Id, ToolType) VALUES(8, 'PNEUMATIC PAINT SPRAYER')");
            Sql("INSERT INTO Category(Id, ToolType) VALUES(9, 'ELECTRIC PAINT SPRAYER')");
            Sql("INSERT INTO Category(Id, ToolType) VALUES(10, 'PRESSURE WASHER')");
            Sql("INSERT INTO Category(Id, ToolType) VALUES(11, 'PNEUMATIC NAIL GUN')");
            Sql("INSERT INTO Category(Id, ToolType) VALUES(12, 'ELECTRIC NAIL GUN')");
            Sql("INSERT INTO Category(Id, ToolType) VALUES(13, 'JACK HAMMER')");
            Sql("INSERT INTO Category(Id, ToolType) VALUES(14, 'COMPRESSOR')");
            Sql("INSERT INTO Category(Id, ToolType) VALUES(15, 'BAND SAW')");
            Sql("INSERT INTO Category(Id, ToolType) VALUES(16, 'FENCE POST DRIVER')");
            Sql("INSERT INTO Category(Id, ToolType) VALUES(17, 'TILE SAW')");
            Sql("INSERT INTO Category(Id, ToolType) VALUES(18, 'GARDEN TILLER')");
            Sql("INSERT INTO Category(Id, ToolType) VALUES(19, 'DIAMOND SAW BLADE')");
            Sql("INSERT INTO Category(Id, ToolType) VALUES(20, 'HARDWOOD INSTALLER')");
        }
        
        public override void Down()
        {
        }
    }
}
