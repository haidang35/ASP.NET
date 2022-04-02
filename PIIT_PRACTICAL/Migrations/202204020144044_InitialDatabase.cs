namespace PIIT_PRACTICAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Coins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        BaseAsset = c.String(nullable: false),
                        QouteAsset = c.String(nullable: false),
                        LastPrice = c.Double(nullable: false),
                        Volume24h = c.Double(nullable: false),
                        MarketId = c.Int(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Markets", t => t.MarketId, cascadeDelete: true)
                .Index(t => t.MarketId);
            
            CreateTable(
                "dbo.Markets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Coins", "MarketId", "dbo.Markets");
            DropIndex("dbo.Coins", new[] { "MarketId" });
            DropTable("dbo.Markets");
            DropTable("dbo.Coins");
        }
    }
}
