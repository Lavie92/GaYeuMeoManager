namespace GaYeuMeoManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateTableOrders : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Orders", "Staff_StaffId", "dbo.Staffs");
            DropIndex("dbo.Orders", new[] { "Customer_CustomerId" });
            DropIndex("dbo.Orders", new[] { "Staff_StaffId" });
            RenameColumn(table: "dbo.Orders", name: "Customer_CustomerId", newName: "CustomerId");
            RenameColumn(table: "dbo.Orders", name: "Staff_StaffId", newName: "StaffId");
            CreateTable(
                "dbo.OrdersDetails",
                c => new
                    {
                        OrdersId = c.Int(nullable: false),
                        ItemName = c.String(),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrdersId)
                .ForeignKey("dbo.Orders", t => t.OrdersId)
                .Index(t => t.OrdersId);
            
            AlterColumn("dbo.Orders", "CustomerId", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "StaffId", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "CustomerId");
            CreateIndex("dbo.Orders", "StaffId");
            AddForeignKey("dbo.Orders", "CustomerId", "dbo.Customers", "CustomerId", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "StaffId", "dbo.Staffs", "StaffId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "StaffId", "dbo.Staffs");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.OrdersDetails", "OrdersId", "dbo.Orders");
            DropIndex("dbo.OrdersDetails", new[] { "OrdersId" });
            DropIndex("dbo.Orders", new[] { "StaffId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            AlterColumn("dbo.Orders", "StaffId", c => c.Int());
            AlterColumn("dbo.Orders", "CustomerId", c => c.Int());
            DropTable("dbo.OrdersDetails");
            RenameColumn(table: "dbo.Orders", name: "StaffId", newName: "Staff_StaffId");
            RenameColumn(table: "dbo.Orders", name: "CustomerId", newName: "Customer_CustomerId");
            CreateIndex("dbo.Orders", "Staff_StaffId");
            CreateIndex("dbo.Orders", "Customer_CustomerId");
            AddForeignKey("dbo.Orders", "Staff_StaffId", "dbo.Staffs", "StaffId");
            AddForeignKey("dbo.Orders", "Customer_CustomerId", "dbo.Customers", "CustomerId");
        }
    }
}
