namespace T2009M_NGUYENHAIDANG_PRACTICAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Exams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Subject = c.String(nullable: false),
                        StartTime = c.String(nullable: false),
                        ExamDate = c.DateTime(nullable: false),
                        Duration = c.Int(nullable: false),
                        ClassRoom = c.String(nullable: false),
                        Faculty = c.String(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Exams");
        }
    }
}
