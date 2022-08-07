namespace GaYeuMeoManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSubscriptionTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.GymSubscriptions", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.GymSubscriptions", "Price");
        }
    }
}
