namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataUpdatedOn1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Data", "updatedOn", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Data", "updatedOn");
        }
    }
}
