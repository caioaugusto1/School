namespace School_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        TeacherName = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(),
                        SurName = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Address1 = c.String(),
                        Address2 = c.String(),
                        Address3 = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Login",
                c => new
                    {
                        Type = c.String(nullable: false, maxLength: 8000, unicode: false),
                        Id = c.Guid(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 40),
                        Password = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CourseStudents",
                c => new
                    {
                        Course_Id = c.Guid(nullable: false),
                        Student_Id = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => new { t.Course_Id, t.Student_Id })
                .ForeignKey("dbo.Courses", t => t.Course_Id, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_Id, cascadeDelete: true)
                .Index(t => t.Course_Id)
                .Index(t => t.Student_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourseStudents", "Student_Id", "dbo.Students");
            DropForeignKey("dbo.CourseStudents", "Course_Id", "dbo.Courses");
            DropIndex("dbo.CourseStudents", new[] { "Student_Id" });
            DropIndex("dbo.CourseStudents", new[] { "Course_Id" });
            DropTable("dbo.CourseStudents");
            DropTable("dbo.Login");
            DropTable("dbo.Students");
            DropTable("dbo.Courses");
        }
    }
}
