namespace T2009M_NGUYENHAIDANG_TEST.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePunished : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PunishedPersons", "Amount", c => c.Single(nullable: false));
            DropColumn("dbo.PunishedPersons", "AmountMoney");
            DropColumn("dbo.PunishedPersons", "Pushup");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PunishedPersons", "Pushup", c => c.Int(nullable: false));
            AddColumn("dbo.PunishedPersons", "AmountMoney", c => c.Single(nullable: false));
            DropColumn("dbo.PunishedPersons", "Amount");
        }
    }
}
