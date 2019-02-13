namespace RoyCityCemetery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DeathRecord_Link",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LinkUrl = c.String(),
                        DeathRecord_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeathRecords", t => t.DeathRecord_Id)
                .Index(t => t.DeathRecord_Id);
            
            CreateTable(
                "dbo.DeathRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        Nickname = c.String(),
                        Sex = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        MarriageDate = c.DateTime(nullable: false),
                        DeathDate = c.DateTime(nullable: false),
                        CauseOfDeath = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DeathRecord_Note",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Note = c.String(),
                        DeathRecord_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeathRecords", t => t.DeathRecord_Id)
                .Index(t => t.DeathRecord_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DeathRecord_Note", "DeathRecord_Id", "dbo.DeathRecords");
            DropForeignKey("dbo.DeathRecord_Link", "DeathRecord_Id", "dbo.DeathRecords");
            DropIndex("dbo.DeathRecord_Note", new[] { "DeathRecord_Id" });
            DropIndex("dbo.DeathRecord_Link", new[] { "DeathRecord_Id" });
            DropTable("dbo.DeathRecord_Note");
            DropTable("dbo.DeathRecords");
            DropTable("dbo.DeathRecord_Link");
        }
    }
}
