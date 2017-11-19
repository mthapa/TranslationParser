namespace NepaliDictionary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNepaliColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Data", "Nepali", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Data", "Nepali");
        }
    }
}
