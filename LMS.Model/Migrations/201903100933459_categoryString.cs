namespace LMS.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categoryString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contents", "Category", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contents", "Category", c => c.Int(nullable: false));
        }
    }
}
