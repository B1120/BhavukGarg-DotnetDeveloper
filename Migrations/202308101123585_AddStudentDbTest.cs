namespace BhavukGarg_DotnetDeveloper.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentDbTest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RollNo = c.Int(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        ClassName = c.String(),
                        Percentage = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
