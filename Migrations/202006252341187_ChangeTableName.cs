namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTableName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.DataModels", newName: "Data");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Data", newName: "DataModels");
        }
    }
}
