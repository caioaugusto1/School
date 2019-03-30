namespace School_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLoginTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Login",
                c => new
                    {
                        Type = c.Int(nullable: false),
                        Id = c.Guid(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 40),
                        Password = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Login");
        }
    }
}
