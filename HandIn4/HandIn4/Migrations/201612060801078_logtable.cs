namespace HandIn4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class logtable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LogReadings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Operations = c.String(),
                        apartmentId = c.Int(nullable: false),
                        ReadingId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LogReadings");
        }
    }
}
