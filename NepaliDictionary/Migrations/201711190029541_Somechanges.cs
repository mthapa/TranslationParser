namespace NepaliDictionary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Somechanges : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Data",
                c => new
                    {
                        DataId = c.Int(nullable: false, identity: true),
                        Romanization = c.String(),
                        Grammar = c.String(),
                        Meaning = c.String(),
                    })
                .PrimaryKey(t => t.DataId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Data");
        }
    }
}
