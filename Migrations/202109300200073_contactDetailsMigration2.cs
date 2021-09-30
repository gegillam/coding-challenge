namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class contactDetailsMigration2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "workPhone", c => c.String());
            AddColumn("dbo.Contacts", "cellNumber", c => c.String());
            AddColumn("dbo.Contacts", "email", c => c.String());
            AddColumn("dbo.Contacts", "zip", c => c.String());
            AddColumn("dbo.Contacts", "street", c => c.String());
            AddColumn("dbo.Contacts", "state", c => c.String());
            AddColumn("dbo.Contacts", "city", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "city");
            DropColumn("dbo.Contacts", "state");
            DropColumn("dbo.Contacts", "street");
            DropColumn("dbo.Contacts", "zip");
            DropColumn("dbo.Contacts", "email");
            DropColumn("dbo.Contacts", "cellNumber");
            DropColumn("dbo.Contacts", "workPhone");
        }
    }
}
