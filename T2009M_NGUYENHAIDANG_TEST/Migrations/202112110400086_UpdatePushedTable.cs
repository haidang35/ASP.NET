namespace T2009M_NGUYENHAIDANG_TEST.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePushedTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PunishedPersons", "Pushup", c => c.Int(nullable: false));
            AddColumn("dbo.PunishedPersons", "CreatedAt", c => c.DateTime(nullable: false));
            DropColumn("dbo.PunishedPersons", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PunishedPersons", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.PunishedPersons", "CreatedAt");
            DropColumn("dbo.PunishedPersons", "Pushup");
        }
    }
}
