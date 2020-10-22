namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataUpdatedBy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Data", "updatedBy", x => x.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Data", "updatedBy");
        }
    }
}
