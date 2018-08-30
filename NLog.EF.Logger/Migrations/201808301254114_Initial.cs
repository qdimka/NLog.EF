namespace NLog.EF.Logger.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LogEntries",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Date = c.String(),
                        Thread = c.String(),
                        Level = c.String(),
                        Logger = c.String(),
                        Message = c.String(),
                        Exception = c.String(),
                        StackTrace = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LogEntries");
        }
    }
}
