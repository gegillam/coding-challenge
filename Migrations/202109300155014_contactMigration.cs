namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contactMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        middleName = c.String(),
                        lastName = c.String(),
                        updatedOn = c.DateTime(nullable: false),
                        updatedBy = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            DropTable("dbo.Data");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Data",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        json = c.String(),
                        title = c.String(),
                        updatedOn = c.DateTime(nullable: false),
                        updatedBy = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            DropTable("dbo.Contacts");
        }
    }
}
