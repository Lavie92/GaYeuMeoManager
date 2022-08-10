namespace GaYeuMeoManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateOrders : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.OrdersDetails", "OrdersId", "dbo.Orders");
            DropPrimaryKey("dbo.OrdersDetails");
            AddPrimaryKey("dbo.OrdersDetails", new[] { "OrdersId", "SubscriptionId" });
            AddForeignKey("dbo.OrdersDetails", "OrdersId", "dbo.Orders", "OrdersId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrdersDetails", "OrdersId", "dbo.Orders");
            DropPrimaryKey("dbo.OrdersDetails");
            AddPrimaryKey("dbo.OrdersDetails", "OrdersId");
            AddForeignKey("dbo.OrdersDetails", "OrdersId", "dbo.Orders", "OrdersId");
        }
    }
}
