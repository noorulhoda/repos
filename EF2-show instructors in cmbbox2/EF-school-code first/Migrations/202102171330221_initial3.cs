namespace EF_school_code_first.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.teachers", "school_ID", "dbo.schools");
            DropIndex("dbo.teachers", new[] { "school_ID" });
            RenameColumn(table: "dbo.teachers", name: "school_ID", newName: "schoolID");
            AlterColumn("dbo.teachers", "schoolID", c => c.Int(nullable: false));
            CreateIndex("dbo.teachers", "schoolID");
            AddForeignKey("dbo.teachers", "schoolID", "dbo.schools", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.teachers", "schoolID", "dbo.schools");
            DropIndex("dbo.teachers", new[] { "schoolID" });
            AlterColumn("dbo.teachers", "schoolID", c => c.Int());
            RenameColumn(table: "dbo.teachers", name: "schoolID", newName: "school_ID");
            CreateIndex("dbo.teachers", "school_ID");
            AddForeignKey("dbo.teachers", "school_ID", "dbo.schools", "ID");
        }
    }
}
