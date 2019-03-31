namespace School_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IncludedColumnNumberVacancies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "NumberVacancies", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "NumberVacancies");
        }
    }
}
