namespace Back_endPart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 20),
                        Priority = c.Int(nullable: false),
                        DeadLineDate = c.DateTime(nullable: false),
                        Description = c.String(nullable: false, maxLength: 100),
                        IsCompleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tasks");
        }
    }
}
