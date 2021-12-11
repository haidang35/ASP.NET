namespace T2009M_NGUYENHAIDANG_TEST.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatePunishedPersonTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PunishedPersons", "AmountMoney", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PunishedPersons", "AmountMoney");
        }
    }
}
