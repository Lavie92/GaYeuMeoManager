namespace GaYeuMeoManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSubscriptionTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GymSubscriptions",
                c => new
                    {
                        SubscriptionId = c.Int(nullable: false, identity: true),
                        SubscriptionName = c.String(),
                    })
                .PrimaryKey(t => t.SubscriptionId);
            
            AddColumn("dbo.OrdersDetails", "SubscriptionId", c => c.Int(nullable: false));
            CreateIndex("dbo.OrdersDetails", "SubscriptionId");
            AddForeignKey("dbo.OrdersDetails", "SubscriptionId", "dbo.GymSubscriptions", "SubscriptionId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrdersDetails", "SubscriptionId", "dbo.GymSubscriptions");
            DropIndex("dbo.OrdersDetails", new[] { "SubscriptionId" });
            DropColumn("dbo.OrdersDetails", "SubscriptionId");
            DropTable("dbo.GymSubscriptions");
        }
    }
}
