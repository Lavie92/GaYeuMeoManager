namespace GaYeuMeoManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAccountPermission : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AccountPermissions",
                c => new
                    {
                        AccountId = c.Int(nullable: false),
                        PermissionId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AccountId, t.PermissionId })
                .ForeignKey("dbo.Accounts", t => t.AccountId, cascadeDelete: true)
                .ForeignKey("dbo.Permissions", t => t.PermissionId, cascadeDelete: true)
                .Index(t => t.AccountId)
                .Index(t => t.PermissionId);
            
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        AccountId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AccountId);
            
            CreateTable(
                "dbo.Permissions",
                c => new
                    {
                        PermissionId = c.Int(nullable: false, identity: true),
                        PermissionName = c.String(),
                    })
                .PrimaryKey(t => t.PermissionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AccountPermissions", "PermissionId", "dbo.Permissions");
            DropForeignKey("dbo.AccountPermissions", "AccountId", "dbo.Accounts");
            DropIndex("dbo.AccountPermissions", new[] { "PermissionId" });
            DropIndex("dbo.AccountPermissions", new[] { "AccountId" });
            DropTable("dbo.Permissions");
            DropTable("dbo.Accounts");
            DropTable("dbo.AccountPermissions");
        }
    }
}
