namespace T2009M_NGUYENHAIDANG_TEST.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePunishedPerson : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PunishedPersons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StudentCode = c.String(nullable: false),
                        Formality = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Categories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ParentId = c.Int(nullable: false),
                        Desc = c.String(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.PunishedPersons");
        }
    }
}
