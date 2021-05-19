namespace EF_school_code_first.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.schools",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        type = c.String(),
                        deptID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.departments", t => t.deptID, cascadeDelete: true)
                .Index(t => t.deptID);
            
            CreateTable(
                "dbo.teacherTransfers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        date = c.DateTime(nullable: false),
                        teacherID = c.Int(nullable: false),
                        from_ID = c.Int(),
                        to_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.schools", t => t.from_ID)
                .ForeignKey("dbo.teachers", t => t.teacherID, cascadeDelete: true)
                .ForeignKey("dbo.schools", t => t.to_ID)
                .Index(t => t.teacherID)
                .Index(t => t.from_ID)
                .Index(t => t.to_ID);
            
            CreateTable(
                "dbo.teachers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        school_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.schools", t => t.school_ID)
                .Index(t => t.school_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.teachers", "school_ID", "dbo.schools");
            DropForeignKey("dbo.teacherTransfers", "to_ID", "dbo.schools");
            DropForeignKey("dbo.teacherTransfers", "teacherID", "dbo.teachers");
            DropForeignKey("dbo.teacherTransfers", "from_ID", "dbo.schools");
            DropForeignKey("dbo.schools", "deptID", "dbo.departments");
            DropIndex("dbo.teachers", new[] { "school_ID" });
            DropIndex("dbo.teacherTransfers", new[] { "to_ID" });
            DropIndex("dbo.teacherTransfers", new[] { "from_ID" });
            DropIndex("dbo.teacherTransfers", new[] { "teacherID" });
            DropIndex("dbo.schools", new[] { "deptID" });
            DropTable("dbo.teachers");
            DropTable("dbo.teacherTransfers");
            DropTable("dbo.schools");
        }
    }
}
