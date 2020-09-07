namespace WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MigrationTests",
                c => new
                    {
                        MigrationTestId = c.Int(nullable: false, identity: true),
                        MigrationName = c.String(),
                        MigrationDiscription = c.String(),
                    })
                .PrimaryKey(t => t.MigrationTestId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MigrationTests");
        }
    }
}
