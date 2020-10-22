namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTitleColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DataModels", "title", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DataModels", "title");
        }
    }
}
