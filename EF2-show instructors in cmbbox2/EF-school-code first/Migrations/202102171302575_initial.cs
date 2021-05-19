namespace EF_school_code_first.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.departments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.departments");
        }
    }
}
