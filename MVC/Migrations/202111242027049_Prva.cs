namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Prva : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Korisniks", "DatumRodjenja", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Korisniks", "DatumRodjenja", c => c.DateTime(nullable: false));
        }
    }
}
