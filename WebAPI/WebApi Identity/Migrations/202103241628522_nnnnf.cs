namespace WebApi_Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nnnnf : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "userID", c => c.String(maxLength: 128));
            CreateIndex("dbo.Students", "userID");
            AddForeignKey("dbo.Students", "userID", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "userID", "dbo.AspNetUsers");
            DropIndex("dbo.Students", new[] { "userID" });
            DropColumn("dbo.Students", "userID");
        }
    }
}
