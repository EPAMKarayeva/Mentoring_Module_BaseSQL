namespace WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNewTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdditionalMigrations",
                c => new
                    {
                        AdditionalMigrationId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.AdditionalMigrationId);
            
            AddColumn("dbo.MigrationTests", "MigrationDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MigrationTests", "MigrationDate");
            DropTable("dbo.AdditionalMigrations");
        }
    }
}
