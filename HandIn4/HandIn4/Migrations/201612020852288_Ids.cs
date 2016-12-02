namespace HandIn4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ids : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appartmentcharacteristics",
                c => new
                    {
                        appartmentId = c.Int(nullable: false, identity: true),
                        No = c.Int(nullable: false),
                        Size = c.Single(nullable: false),
                        Floor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.appartmentId);
            
            CreateTable(
                "dbo.Readings",
                c => new
                    {
                        ReadingId = c.Long(nullable: false, identity: true),
                        sensorId = c.Int(nullable: false),
                        appartmentId = c.Int(nullable: false),
                        value = c.Single(nullable: false),
                        timestamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReadingId);
            
            CreateTable(
                "dbo.Sensorcharacteristics",
                c => new
                    {
                        SensorcharacteristicId = c.Int(nullable: false, identity: true),
                        calibrationCoeff = c.String(),
                        description = c.String(),
                        calibrationDate = c.DateTime(nullable: false),
                        externalRef = c.String(),
                        sensorId = c.Int(nullable: false),
                        unit = c.String(),
                        calibrationEquation = c.String(),
                    })
                .PrimaryKey(t => t.SensorcharacteristicId);
            
            CreateTable(
                "dbo.SensorDatas",
                c => new
                    {
                        SensorDataId = c.Int(nullable: false, identity: true),
                        version = c.Int(nullable: false),
                        timestamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SensorDataId);
            
            CreateTable(
                "dbo.SystemDatas",
                c => new
                    {
                        SystemDataId = c.Int(nullable: false, identity: true),
                        timestamp = c.DateTime(nullable: false),
                        version = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SystemDataId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SystemDatas");
            DropTable("dbo.SensorDatas");
            DropTable("dbo.Sensorcharacteristics");
            DropTable("dbo.Readings");
            DropTable("dbo.Appartmentcharacteristics");
        }
    }
}
