namespace GaYeuMeoManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerTable1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Gender = c.Boolean(nullable: false),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
