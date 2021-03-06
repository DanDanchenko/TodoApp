namespace Back_endPart.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Change4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tasks", "Title", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Tasks", "Description", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tasks", "Description", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Tasks", "Title", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
