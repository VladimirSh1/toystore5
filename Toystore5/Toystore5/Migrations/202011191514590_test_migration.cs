namespace Toystore5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test_migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Toys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "Position", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Position");
            DropTable("dbo.Toys");
        }
    }
}
