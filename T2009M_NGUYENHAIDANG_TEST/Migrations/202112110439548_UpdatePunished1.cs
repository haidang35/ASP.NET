namespace T2009M_NGUYENHAIDANG_TEST.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePunished1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PunishedPersons", "Formality", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PunishedPersons", "Formality", c => c.String(nullable: false));
        }
    }
}
