namespace School_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeColumnTypeVarchar : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "Name", c => c.String(maxLength: 40, unicode: false));
            AlterColumn("dbo.Courses", "TeacherName", c => c.String(maxLength: 40, unicode: false));
            AlterColumn("dbo.Students", "FirstName", c => c.String(maxLength: 40, unicode: false));
            AlterColumn("dbo.Students", "SurName", c => c.String(maxLength: 40, unicode: false));
            AlterColumn("dbo.Students", "Address1", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Students", "Address2", c => c.String(maxLength: 100, unicode: false));
            AlterColumn("dbo.Students", "Address3", c => c.String(maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Address3", c => c.String());
            AlterColumn("dbo.Students", "Address2", c => c.String());
            AlterColumn("dbo.Students", "Address1", c => c.String());
            AlterColumn("dbo.Students", "SurName", c => c.String(maxLength: 40));
            AlterColumn("dbo.Students", "FirstName", c => c.String(maxLength: 40));
            AlterColumn("dbo.Courses", "TeacherName", c => c.String(maxLength: 40));
            AlterColumn("dbo.Courses", "Name", c => c.String(maxLength: 40));
        }
    }
}
